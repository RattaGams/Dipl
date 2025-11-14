******************
     READ ME
******************


---------------------------
Testen des Unity-Projekts
---------------------------

	Zuerst die Szene als aktuelle Szene auswählen
		im Projektordner unter Assets/Scenes/ die "Test Szene" auswählen (doppelklick)
	Danach in der Game view das spiel von "Play Focused" zu "Play Maximized" umstellen (Drop down menu)
		ist im Gameview Fenster über der Kamerasicht neben dem Scale zu finden
	Zum Bewegen ist Zurzeit sowohl der linke Controller als auch Handbewegungen aktiviert


---------------------------
Wege
---------------------------

	Wege funktionieren derzeit über die neuen Cubes 
		Die Cubes haben den Tag Pfad welcher im transform vom PathFollow script ausgelesen wird
		Das Script sucht nach dem nähesten Objekt mit dem Pfad tag und überprüft die distanz zu diesem
		wenn sich das XR Rig (Spieler) zu weit wegbewegt wird eine warnung ausgegeben (debug console)
	Müssen einzelne Objekte bleiben um das Ping system zu verwenden
	Pings funktionieren Momentan so das sie einen Immer ansehen und sobald man nah genug zu ihnen geht wird der Nächste aktiviert
	Wenn alle Pings durchgegangen worden sind startet es wieder von vorne
	Pings müssen noch abgeändert werden sodass sie durch Wände sehbar sind (Nicht unbedingt notwendig wenn die Wege schön anneinander reihen)
	(WIP!!!) Shader um Ping durch die wände zu sehen hinzugefügt funktioniert noch nicht
		Der Shader code ist momentan im Ping script auskommentiert
		wenn der Code wieder aktiviert wird verschwinded der Ping aus irgendeinem grund
	

	Die Wege des Herrens sind unergründlich
	i nomine patris et filii et spiritus sancti

---------------------------
Movement
---------------------------

	Wenn man den Movespeed der Sensoren des KatWalks anpassen will muss man den Speed des dynamic move providers abändern (Höher = schneller)


---------------------------
Soundsystem
---------------------------
	Das Soundsystem funktioniert mit vorgefertigten mp3 files die unter scripts>pfad zu finden sind.
		- Jeder Ping-Target kann eine Nummer zugewiesen bekommen, die einem spezifischen Audio-Clip entspricht.
        - Die Audio-Clips werden in der TTSSystem-Komponente verwaltet.
        - Wenn ein Ping aktiviert wird, wird der entsprechende Audio-Clip abgespielt.
        - Die Audio-Clips können im Inspector des TTSSystem-Objekts zugewiesen werden.

    So richtet man das Soundsystem ein:
        1. Füge das TTSSystem-Skript zu einem GameObject in der Szene hinzu.
        2. Weise im Inspector die Audio-Clips den entsprechenden Nummern zu.
        3. Stelle sicher, dass die Nummern in den PingTargets mit denen im TTSSystem übereinstimmen.
        4. Teste das System, indem du die Szene ausführst und die Pings aktivierst.

	Derzeit ist das TTS Script dem TTSManager unter dem XR Origin Rig>Camera Ofset>Main Camera zugeordnet.


--------------------------
Menus
--------------------------

	https://www.youtube.com/watch?v=6PSLfRsN89g&pp=ygUXSGFuZCBnYXplIG1lbnUgdnIgdW5pdHk%3D

	Das Handmenu wurde mit hilfe diesem Tutorials gemacht und uhhh.. Ist der linken Hand zugewiesen

	Das Hauptmenu ist in einer eigenen Scene und ist einfacher als das Handmenu gestaltet