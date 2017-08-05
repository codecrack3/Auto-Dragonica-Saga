#include <MsgBoxConstants.au3>
#include <WinAPIFiles.au3>
#RequireAdmin
#NoTrayIcon
Local $aPos = WinGetPos("[ACTIVE]")
$handle = WinGetHandle("[CLASS:Gamebryo Application]")
Local $aClientSize = WinGetClientSize($handle)

Global const $path = "D:\config.ini"
Global $dl1,$key1,$dl2,$key2,$dl3,$key3,$stand_only,$not_attack,$d_x,$d_y
ToolTip("Auto đang khởi động đấy nhé !",$aClientSize[0]+195,$aClientSize[1],"Auto")

load_config()
Global $TIMER = TimerInit()
global $timerg = TimerInit()
Global const $ss = 1000
Global Const $TIMEOUT1 = $dl1
Global Const $TIMEOUT2 = $dl2
Global Const $TIMEOUT3 = $dl3
While 1

 attack()
 slot_timer()

WEnd


func attack()
	if($d_x <> "" and $d_y <> "" and $not_attack == "0" and $stand_only == "0") Then

	If TimerDiff($TIMER) <= ($d_x * 1000) Then
        fuck_x()


	Elseif TimerDiff($TIMER) >= ($d_x * 1000) and TimerDiff($TIMER) <= (($d_x * 1000)+($d_y * 1000)) then
		fuck_y()


	Else
		$TIMER = TimerInit();
	EndIf
	EndIf
	if($not_attack == "1") Then
		Sleep(500)
	EndIf
	if($stand_only == "1") Then
	fuck_not();
		EndIf
	EndFunc


Func fuck_not()

$handle = WinGetHandle("[CLASS:Gamebryo Application]")

	If $handle = -1 Then
		exit
	Else

	ControlSend($handle,"","","x")

	ControlSend($handle,"","","x")

	ControlSend($handle,"","","x")

	ControlSend($handle,"","","x")

	ControlSend($handle,"","","x")

	ControlSend($handle,"","","x")

	ControlSend($handle,"","","x")

	ControlSend($handle,"","","x")

	ControlSend($handle,"","","x")

	ControlSend($handle,"","","x")

	ControlSend($handle,"","","x")

	ControlSend($handle,"","","x")

	ControlSend($handle,"","","x")

	ControlSend($handle,"","","x")
	ControlSend($handle,"","","x")

	ControlSend($handle,"","","x")

	ControlSend($handle,"","","x")

	ControlSend($handle,"","","x")

	ControlSend($handle,"","","x")

	ControlSend($handle,"","","x")


	Sleep(150)


	EndIf
EndFunc

Func fuck_x()

$handle = WinGetHandle("[CLASS:Gamebryo Application]")

	If $handle = -1 Then
		exit
	Else

	ControlSend($handle,"","","x")
	ControlSend($handle,"","","{right}")
	ControlSend($handle,"","","x")
	ControlSend($handle,"","","{right}")
	ControlSend($handle,"","","x")
	ControlSend($handle,"","","{right}")
	ControlSend($handle,"","","x")
	ControlSend($handle,"","","{right}")
	ControlSend($handle,"","","x")
	ControlSend($handle,"","","{right}")
	ControlSend($handle,"","","x")
	ControlSend($handle,"","","{right}")
	ControlSend($handle,"","","x")
	ControlSend($handle,"","","{right}")
	ControlSend($handle,"","","x")
	ControlSend($handle,"","","{right}")
	ControlSend($handle,"","","x")
	ControlSend($handle,"","","{right}")
	ControlSend($handle,"","","x")
	ControlSend($handle,"","","{right}")
	ControlSend($handle,"","","x")
	ControlSend($handle,"","","{right}")
	ControlSend($handle,"","","x")
	ControlSend($handle,"","","{right}")
	ControlSend($handle,"","","x")
	ControlSend($handle,"","","{right}")
	ControlSend($handle,"","","x")
	ControlSend($handle,"","","{right}")
	ControlSend($handle,"","","x")
	Sleep(150)
	ControlSend($handle,"","","{right}")



	EndIf
EndFunc

Func fuck_y()

$handle = WinGetHandle("[CLASS:Gamebryo Application]")

	If $handle = -1 Then
		exit
	Else

	ControlSend($handle,"","","x")
	ControlSend($handle,"","","{left}")
	ControlSend($handle,"","","x")
	ControlSend($handle,"","","{left}")
	ControlSend($handle,"","","x")
	ControlSend($handle,"","","{left}")
	ControlSend($handle,"","","x")
	ControlSend($handle,"","","{left}")
	ControlSend($handle,"","","x")
	ControlSend($handle,"","","{left}")
	ControlSend($handle,"","","x")
	ControlSend($handle,"","","{left}")
	ControlSend($handle,"","","x")
	ControlSend($handle,"","","{left}")
	ControlSend($handle,"","","x")
	ControlSend($handle,"","","{left}")
	ControlSend($handle,"","","x")
	ControlSend($handle,"","","{left}")
	ControlSend($handle,"","","x")
	ControlSend($handle,"","","{left}")
	ControlSend($handle,"","","x")
	ControlSend($handle,"","","{left}")
	ControlSend($handle,"","","x")
	ControlSend($handle,"","","{left}")
	ControlSend($handle,"","","x")
	ControlSend($handle,"","","{left}")
	ControlSend($handle,"","","x")
	ControlSend($handle,"","","{left}")
	ControlSend($handle,"","","x")
	ControlSend($handle,"","","{left}")
	ControlSend($handle,"","","x")
	Sleep(150)
	ControlSend($handle,"","","{left}")

	EndIf
EndFunc

func check_key()
	$handle = WinGetHandle("[CLASS:Gamebryo Application]")

	If $handle = -1 Then
		exit
	Else
	if($key1 <> "" and $dl1 <> "") then
	Sleep($dl1*$ss)
	ControlSend($handle,"","",$key1)
	ElseIf($key2 <> "" and $dl2 <> "") Then
	Sleep($dl2*$ss)
	ControlSend($handle,"","",$key2)
	ElseIf($key3 <> "" and $dl3 <> "") Then
	Sleep($dl3*$ss)
	ControlSend($handle,"","",$key3)

	Else
	Sleep(100)

	EndIf
	EndIf
EndFunc

Func slot_timer()
If TimerDiff($TIMER) >= $TIMEOUT1 and $TIMEOUT1 <> "" Then
        slot1()
		Sleep(300)
EndIf
If TimerDiff($TIMER) >= $TIMEOUT2 and $TIMEOUT2 <> "" Then
    slot2()
	Sleep(300)
EndIf
If TimerDiff($TIMER) >= $TIMEOUT3 and $TIMEOUT3 <> "" Then
	slot3()
	Sleep(300)
EndIf
EndFunc



Func slot1()
	$handle = WinGetHandle("[CLASS:Gamebryo Application]")

	If $handle = -1 Then
		exit
	Else
		ControlSend($handle,"","",$key1)
		EndIf
EndFunc

Func slot2()
	$handle = WinGetHandle("[CLASS:Gamebryo Application]")

	If $handle = -1 Then
		exit
	Else
		ControlSend($handle,"","",$key2)
		EndIf
EndFunc

Func slot3()
	$handle = WinGetHandle("[CLASS:Gamebryo Application]")

	If $handle = -1 Then
		exit
	Else
		ControlSend($handle,"","",$key3)
		EndIf
EndFunc




Func load_config()
	If FileExists("D:\config.ini") Then
	$dl1 = IniRead($path, "config_auto", "dl1", "")
	$key1 = IniRead($path, "config_auto", "key1", "")
	$dl2 = IniRead($path, "config_auto", "dl2", "")
	$key2 = IniRead($path, "config_auto", "key2", "")
	$dl3 = IniRead($path, "config_auto", "dl3", "")
	$key3 = IniRead($path, "config_auto", "key3", "")
	$stand_only = IniRead($path, "config_auto", "stand_only", "")
	$not_attack = IniRead($path, "config_auto", "not_attack", "")
	$d_x = IniRead($path, "config_auto", "d_x", "")
	$d_y = IniRead($path, "config_auto", "d_y", "")

Else
	MsgBox(0,"Error","Không tìm thấy file config !")
	Exit
EndIf
	EndFunc