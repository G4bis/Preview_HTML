*26/11/2016
*Preview HTML
*4I1, Gruppo: Giudici, Berzi


Il cliente richiede un software in cui venga simulata la funzione di un browser, l&#39;utente inserirà il codice HTML e CSS all&#39;interno di due campi di testo, e  il software restituirà immediatamente l&#39;anteprima della pagina web.

Inoltre dovrà essere possibile generare i file .HTML e .CSS tramite due appositi tasti.

Lo scopo è quello di fare imparare o provare il linguaggio HTML all&#39;utente.

- Tecnologie utilizzate: Visual Studio 2015, GitHub
- Tipi di file utilizzati: .cs, .html, .css, .sln
-  Le cartelle create da programma saranno create nel seguente percorso con all&#39;interno due file , di seguito due screenshot dimostrativi

 ![](http://imageshack.com/a/img924/5885/kyIIF9.png)
 ![](http://imageshack.com/a/img922/5899/kswil3.png)
 
- Tutto il progetto con le varie versioni è stato caricato su GitHub tramite Git , nella repository [https://github.com/G4bis/Preview\_HTML.git](https://github.com/G4bis/Preview_HTML.git)  . Il programma può essere eseguito su Windows 7/8 e 10 in qualsiasi posizione del pc. Sarebbe Inoltre necessario eseguirlo come amministratore data la necessità di creare file sul pc , il che non sarebbe possibile se non si dispone dei permessi opportuni.

**Corpo del problema**

- Il lavoro si può collocare in due diversi ambiti , privato , per un utente più o meno esperto , con delle conoscenze di codice anche solo html , oppure anche in ambito lavorativo , dove un utente con conoscenze sia di css , sia di html e perfino di Javascript può andare ad utilizzare il programma.
- Un esempio d&#39;uso per un utente con conoscenze medio-basse può servire a compilare un progetto in html costituito da una sola pagina html e da una css, invece in un ambito lavorativo potrebbe essere usato come tester , ovvero come software &quot;immediato&quot; per provare pezzi di codice prima di inserirli in un progetto esterno.
- Il programma è composto da un form principale all&#39;avvio , e poi tramite due bottoni si possono far apparire altri due form supplementari. Il programma creerà due file sul disco C:\ all&#39;interno di una cartella.Questi saranno fondamentali se si vorrà poi esportare il progetto.
- L&#39;unica classe utilizzata è la classe Form , da cui derivano poi le classi figlie Form1,Form2,Form3. Non sono state utilizzate altre classi

**Progettazione:**

Bozza dell&#39;interfaccia: ![](MA METTERE LA BOZZA!)

**Screenshots:**

Prima schermata all&#39;avvio
 ![](http://imageshack.com/a/img924/5306/UizhKj.jpg)
 
 Successivamente premendo i bottoni &quot;Aggiungi codice HTML&quot; e &quot;Aggiungi codice CSS&quot; compariranno altre 2 form:
 ![](http://imageshack.com/a/img922/2106/hOeXxl.jpg)
 
 Dopodiché è possibile scrivere il proprio codice HTML e CSS e verrà restituita immediatamente la pagina Web:
 ![](http://imageshack.com/a/img923/6448/rpYlSV.jpg)
 
 Per salvare il codice HTML e CSS su file è necessario premere sugli appositi bottoni &quot;Salva HTML&quot; e &quot;Salva CSS&quot; (il file verrà messo in C:\HTMLpreviewer): ![](http://imageshack.com/a/img923/5228/5HDQDu.jpg)


**Conclusione:**

In generale il programma è intuitivo e funzionale , l&#39;interfaccia è semplice anche per un utente con poche conoscenze informatiche

Il lavoro è completo e nella fase di test non sono stati trovati errori. In futuro si può sicuramente migliorare e implementare nuove funzioni , come per esempio una possibile scelta del percorso dove salvare i file , oppure caricare un progetto già esistente .

**Bibliorafia**

MSDN Microsoft

Stack Overflow
