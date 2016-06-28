#!/bin/bash

command -v mono >/dev/null 2>&1 || { 
  MONOERR="Mono not found! Please install it using 'sudo apt-get install mono-complete mono-vbnc'"
  echo $MONOERR
  command -v zenity >/dev/null 2>&1 && zenity --info --text=$MONOERR || sleep 10
  exit 1
}
mono "halogenOS Installer.exe">/dev/null
exit 0
