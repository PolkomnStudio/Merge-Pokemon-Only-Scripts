Shader "HighlightPlus/Geometry/Outline" {
	Properties {
		_MainTex ("Texture", any) = "white" {}
		_OutlineColor ("Outline Color", Vector) = (0,0,0,1)
		_OutlineWidth ("Outline Offset", Float) = 0.01
		_OutlineDirection ("Outline Direction", Vector) = (0,0,0,1)
		_Color ("Color", Vector) = (1,1,1,1)
		_Cull ("Cull Mode", Float) = 2
		_ConstantWidth ("Constant Width", Float) = 1
		_OutlineZTest ("ZTest", Float) = 4
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
}