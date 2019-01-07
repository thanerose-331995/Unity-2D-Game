// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

Shader "Sprites/grayScale"
{
	Properties
	{
		[PerRendererData] _MainTex("Sprite Texture", 2D) = "white" {} //standard render stuff
		_Color("Tint", Color) = (1,1,1,1) //setting the colour(r,g,b,a) as grey
		[MaterialToggle] PixelSnap("Pixel snap", Float) = 0 //means the tilemap wont 'tear', can turn on and off
		_EffectAmount("Effect Amount", Range(0, 1)) = 1.0 //can change the effect as a slider in the properties bit
	}

		SubShader
		{
			Tags //setting type for the shader
			{
				"Queue" = "Transparent"
				"IgnoreProjector" = "True"
				"RenderType" = "Transparent"
				"PreviewType" = "Plane"
				"CanUseSpriteAtlas" = "True"
			}

			Lighting On 
			ZWrite Off //controls wether pixels are drawin into the depth buffer, 'off' draws semitransparent objects
			Blend SrcAlpha OneMinusSrcAlpha //transparency

			Pass
			{
			CGPROGRAM
				#pragma vertex vert
				#pragma fragment frag
				#pragma multi_compile DUMMY PIXELSNAP_ON
				#include "UnityCG.cginc"

				struct appdata_t
				{
					float4 vertex   : POSITION;
					float4 color    : COLOR;
					float2 texcoord : TEXCOORD0;
				};

				struct v2f
				{
					float4 vertex   : SV_POSITION;
					fixed4 color : COLOR;
					half2 texcoord  : TEXCOORD0;
				};

				fixed4 _Color;

				v2f vert(appdata_t IN)
				{
					v2f OUT;
					OUT.vertex = UnityObjectToClipPos(IN.vertex);
					OUT.texcoord = IN.texcoord;
					OUT.color = IN.color * _Color;
					#ifdef PIXELSNAP_ON
					OUT.vertex = UnityPixelSnap(OUT.vertex);
					#endif

					return OUT;
				}

				sampler2D _MainTex;
				uniform float _EffectAmount;

				fixed4 frag(v2f IN) : COLOR
				{
					half4 texcol = tex2D(_MainTex, IN.texcoord);
					texcol.rgb = lerp(texcol.rgb, dot(texcol.rgb, float3(0.3, 0.59, 0.11)), _EffectAmount);
					texcol = texcol * IN.color;
					return texcol;
				}
			ENDCG
			}
		}
			Fallback "Sprites/Default"
}