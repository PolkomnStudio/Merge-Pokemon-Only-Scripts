Shader "Pinpin/CustomLighting/Metamon" {
	Properties {
		_MainTex ("MainTex", 2D) = "white" {}
		_Color ("Color", Vector) = (1,1,1,1)
		[Header(Shadow)] [Space] _ShadowColor ("Shadow Color", Vector) = (0,0,0,0)
		_RampThreshold ("Ramp Threshold", Range(-1, 1)) = 0
		_RampSmooth ("Ramp Smooth", Range(0.01, 2)) = 1
		_ShadowIntensity ("Shadow Intensity", Range(0, 1)) = 1
		_ExtraShadowIntensity ("Extra Shadow Intensity", Range(0, 1)) = 1
		[Header(Fresnel)] [Space] _FresnelColor ("Fresnel Color", Vector) = (0.5518868,1,0.9771387,1)
		_FresnelScale ("Fresnel Scale", Range(0, 2)) = 1
		_FresnelPower ("Fresnel Power", Range(0, 5)) = 2.5
		[Header(Other)] [Space] _Saturation ("Saturation", Range(0, 5)) = 1
		_LuminosityValue ("Luminosity Value", Range(0, 5)) = 1
		_HueShift ("Hue Shift", Range(0, 1)) = 0
		[HideInInspector] _texcoord ("", 2D) = "white" {}
		[HideInInspector] __dirty ("", Float) = 1
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		sampler2D _MainTex;
		fixed4 _Color;
		struct Input
		{
			float2 uv_MainTex;
		};
		
		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			fixed4 c = tex2D(_MainTex, IN.uv_MainTex) * _Color;
			o.Albedo = c.rgb;
			o.Alpha = c.a;
		}
		ENDCG
	}
	Fallback "Diffuse"
	//CustomEditor "ASEMaterialInspector"
}