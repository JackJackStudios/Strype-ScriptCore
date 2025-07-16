StrypeDirectory = os.getenv("STRYPE_DIR")

include "../Coral"

project "Strype-ScriptCore"
	kind "SharedLib"
	language "C#"
	dotnetframework "net8.0"
	clr "Unsafe"
    targetdir("../bin")
    objdir("../bin")

	links {
		"Coral.Managed"
	}

	files {
		"%{wks.location}/Strype-ScriptCore/Source/**.cs",
	}