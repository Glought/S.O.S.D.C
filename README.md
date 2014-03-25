S.O.S.D.C: Simple On Screen Death Counter.
=========

Simple On Screen Death Counter for streamers (twitchtv ,Ustream,etc). Increments count by 1 when hotkey its pressd and saves it to a text file stored where the program's exe is stored. Just point xsplits/obs remote link/file to the file "Count.txt"

Just need .net framework 4 client profile to run.

How To Use
=========

Its very simple to use first click on settings and set your Hotkey you want to use. 
Then click on apply. Change Message to what you want it to say its by default set to "Death Count"  
Then click on "Start/Save" to Enable the hotkey and save Message. "S" will disable the hotkey.
"Reset Count" will reset the count.

The Indicator will change from Red to Green when the hotkey is enabled.



Settings
==========

Start Tag:For use in Xsplit. Remove for use in OBS>Default: "<xsplit>

End Tag: For use in Xsplit. Remove for use in OBS>Default: "</xsplit>

HotKey: Select from the list what hotkey you want to use:Default:H

Save Count:When checked will save count number.Usefull when you want to continue your stream/video at a later date.Default:Off

Reverse Text Order:Reverses the text order in text file.Off:"Message:Count" On:"Count:Message".Default:Off

Don't Change hotkey:Check this when you don't want the hotkey changed.Uncheck when you want to change the hotkey.

Current HotKey:Sates the current hotkey.


Building
==========
Just need  Microsof visual studio(or C#) 2010 express and .net framework 4 client profile.


License
===========
  Simple On Screen Death Counter(S.O.S.D.C) Increments a number when a hotkey is press to a txt file.
  Copyright 2014 ThoughtsOfGlought

  Simple On Screen Death Counter(S.O.S.D.C) is free software: you can redistribute it and/or modify
  it under the terms of the GNU General Public License as published by
  the Free Software Foundation, either version 3 of the License, or
  (at your option) any later version.

  Simple On Screen Death Counter(S.O.S.D.C) is distributed in the hope that it will be useful,
  but WITHOUT ANY WARRANTY; without even the implied warranty of
  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
  GNU General Public License for more details.

  You should have received a copy of the GNU General Public License
  along with Simple On Screen Death Counter(S.O.S.D.C).  If not, see <http://www.gnu.org/licenses/>.
