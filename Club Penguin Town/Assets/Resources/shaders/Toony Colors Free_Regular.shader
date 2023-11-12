Shader "Toony Colors Free/Regular" {
	Properties {
		_Color ("Color", Vector) = (0.5,0.5,0.5,1)
		_HColor ("Highlight Color", Vector) = (0.8207547,0.8207547,0.8207547,1)
		_SColor ("Shadow Color", Vector) = (0.3867925,0.3867925,0.3867925,1)
		_MainTex ("Main Texture (RGB)", 2D) = "white" {}
		_Ramp ("Toon Ramp (RGB)", 2D) = "gray" {}
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
	//CustomEditor "TCF_MaterialInspector"
}