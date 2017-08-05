#include <MsgBoxConstants.au3>
#include <WinAPIFiles.au3>
#RequireAdmin
Global const $path = "D:\config.ini"
Global $dnhp,$key_dnhp,$dnmp,$key_dnmp;
load_config()


If $CMDLine[0] > 0 Then
		$handle = WinGetHandle("[CLASS:Gamebryo Application]")
      If $cmdline[1] = "/hp" then

	  if $handle <> -1 Then
		  ;MsgBox(0,"","hp ok")
		  ControlSend($handle,"","",$key_dnhp)
	EndIf


      ElseIf ($cmdline[1] = "/mp") then
		if $handle <> -1 Then
			;MsgBox(0,"","mp ok")
		  ControlSend($handle,"","",$key_dnmp)
	  EndIf
	  EndIf
	  EndIf


	  Func load_config()
	If FileExists("D:\config.ini") Then
	$dnhp = IniRead($path, "config_auto", "dnhp", "")
	$key_dnhp = IniRead($path, "config_auto", "key_dnhp", "")
	$dnhp = IniRead($path, "config_auto", "dnhp", "")
	$key_dnhp = IniRead($path, "config_auto", "key_dnhp", "")
Else
	MsgBox(0,"Error","Không tìm thấy file config")
	Exit
EndIf
	EndFunc