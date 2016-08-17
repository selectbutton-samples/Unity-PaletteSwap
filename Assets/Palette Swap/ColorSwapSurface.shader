Shader "Custom/ColorSwapSurface" {
	Properties {
		_MainTex ("Channels", 2D) = "white" {}
		_Channel1 ("Channel 1 Color (R)", Color) = (1,1,1,1)
		_Channel2 ("Channel 2 Color (G)", Color) = (0.66,0.66,0.66,1)
		_Channel3 ("Channel 3 Color (B)", Color) = (0.33,0.33,0.33,1)
		_AlphaCutoff ("Alpha Cutoff", Range(0,1))= 0.5

		_Glossiness ("Smoothness", Range(0,1)) = 0.0
		_Metallic ("Metallic", Range(0,1)) = 0.0
	}
	SubShader {
		//Tags { "Queue" = "Transparent" "RenderType"="Opaque" }
		Tags { "RenderType"="Opaque" }

		LOD 200
		Cull off
		CGPROGRAM
		// Physically based Standard lighting model, and enable shadows on all light types
		#pragma surface surf Standard fullforwardshadows alphatest:_AlphaCutoff addshadow

		// Use shader model 3.0 target, to get nicer looking lighting
		#pragma target 3.0

		sampler2D _MainTex;

		struct Input {
			float2 uv_MainTex;
		};

		half _Glossiness;
		half _Metallic;
		fixed4 _Channel1;
		fixed4 _Channel2;
		fixed4 _Channel3;

		void surf (Input IN, inout SurfaceOutputStandard o) {
			// Albedo comes from a "channel" texture and three color pickers.
				// The redness of a pixel determines that pixel's "channel 1 strength." If a pixel has a 0.5 (or 128) red value, it will be tinted at half strength the color in the first channel.
				// The Green channel is the second channel.
				// The Blue channel is the third channel.
				// Alpha controls transparency. If the Alpha value is above the Alpha Cutoff, that pixel is drawn. Otherwise, it remains transparent.
			fixed4 cc = tex2D (_MainTex, IN.uv_MainTex);
			o.Albedo = (cc.r * _Channel1) + (cc.g * _Channel2) + (cc.b * _Channel3);
			// Metallic and smoothness come from slider variables
			o.Metallic = _Metallic;
			o.Smoothness = _Glossiness;
			o.Alpha = cc.a;
		}
		ENDCG
	}
	FallBack "Diffuse"
}
