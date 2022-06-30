# De Bonte Beestenboel

## Intro

Elke goede Hoogstratenaar stoeft altijd met 2 dingen: De aardbeien en de keer
dat hij/zij naar de Kinderboerderij de Bonte Beestenboel ging. Het is hier
altijd een drukke bedoening met de dieren en de beestjes die komen bezoeken
(6-7 jarige kinderen). Het managment team (aka de hoofdboer) heeft dus besloten
om een tool te laten ontwikkelen, echter was het budget niet heel hoog dus hier
is hun vraag in vorm van een (voorbeeld)examen.

## Hoe te werk gaan?

Voor je begint is deze taak ontworpen om zo veel mogelijk tijdsdruk en stress
te veroorzaken. Er zullen dus een paar factoren zijn om dit zo "efficient"
mogelijk te doen.


### Starten

Het (voorbeeld)examen duurt exact 2 uur (exclusief opdrachten lezen), alles dat
na 2 uur wordt ingedient wordt niet verebtert. Ik ga dit controleren d.m.v.
git, eerst maak je een fork van de repo (dit dient als initiele factor om de
tijd na te kijken). Hierna clone je deze fork naar je lokale computer en maak
je direct een file (start.txt) aan met de huidige datum en tijd in en commit je
met de naam "[START]". Je pushed deze commit direct en dan start het examen.

### Tijdens het examen

Commit zoveel mogelijk (pushen kan later) en liefst met opdracht nummers in de message.

### Eindigen

Eindigen is ingedeeld in meerdere stappen, eerst commit je alle changes nog
eens en pushed deze terug naar je fork. Als dit gebeurt is maak je een zip van
al je bestanden (en de .git folder) en upload deze naar discord (indien te
groot een WeTransfer Link). Zie dat dit **OOK gebuert BINNEN de tijd**.

Als alles gedaan is je examen succesvol beeindigt. Echter voor het mij wat
makkelijker te maken, ga je een pull request maken naar de originele examen
repo. Dit valt buiten de tijd, dus doe dit **NA** het inleveren van de zip.

> Is er voldoende tijd om deze opdracht af te ronden: 
>
> **Hoogst waarschijnlijk niet!**

## Hulpmiddelen

Enkel de hulpmiddelen dat gelden op het OOP examen zijn toegelaten op dit
examen. Echter is er hier geen controle van, maar slik geen gifpil voor
deze mooie opdracht, ze is er om je te helpen.


## Opdracht

Jouw opdracht is een systeem ontwikkelen zodat de verschillende activiteiten
goed bemant worden. Echter heeft niet iedereen ervaring met alle taken, zo
kunnen sommige werknemers zeer goed dieren voederen, maar helemaal geen boter
maken en omgekeerd.

Ook hebben deze mensen een contract en werken dus halftijds (4 uur) of voltijds
(8 uur).  Het is de bedoeling om mensen zo efficient mogelijk hun activiteiten
te laten in plannen. En zo veel modelijk kinderen in te plannen. Werknemers die
halftijds werken mogen enkel in de voormiddag (8u - 12u) en namiddag (12u - 16u)
ingepland worden.


**Lees eerst alle opdrachten voordat je begint te coderen.**

### 1. Maak voor elk soort medewerker een object aan met vaardigehden.

Soorten werknemers:

* Animal Caretakers
    * Deze mensen houden zich bezig met de dieren te verzorgen.
* Cook & Baker
    * Deze mensen gaan samen met de kinderen van verse koeienmelk boter en slagroom maken, of gaan de kaas uit de kelder halen en opsmullen.
* Arts & Crafter
    * Met deze mensen gaan de kinderen 1001 dingen maken met wol en pauwen veren.

### 2. Maak een interface aan om zelf werknemers toe te voegen.

De start hiervan is al gemaakt.

Maak ook voor het debuggen zelf een method aan om snel (random of manueel)
workers toe te voegen, zonder gebruik te maken van de console interface.

### 3. Maak slim gebruik van overerving en polymorphisme, en maak zo min mogelijk objecten aan.

Elke soort activiteit kan ook maar een maximaal aantal kinderen bedienen en
heeft een bepaalde duurtijd.

* Animal Caretakers
    * Dieren voederen (30 kinderen, 2 uur, maximaal 2 keer per dag)
    * Schapen scheren (10 kinderen, 2 uur, maximaal 1 keer per dag)
    * Diertjes aaien (30 kinderen, 2 uur)
* Cook & Baker
    * Boter maken (20 kinderen, 1 uur)
    * Slagroom maken (20 kinderen, 1 uur)
    * Kaas opsmullen (onbeperkt aantal kinderen, 1 uur, maximaal 1 keer per dag)
* Arts & Crafter
    * Beestjes haken (10 kinderen, 3 uur)
    * Breien 101 (10 kinderen, 2 uur)
    * 1 2 3 4 Hoedjes van papier maken (onbeperkt aantal kinderen, 1 uur)

Meerdere activiteiten kunnen later toegevoegd worden, liefst zonder extra programeer werk.
(Hard coded generator method mag wel)

### 4. Print alle werknemers af

```
Jan de Schapennemer:
  Voltijds
  Animal Caretaker

Lieve Kazeeter:
  Halftijds
  Cook & Baker

Chantal Naaldenmeester:
  Voltijds
  Arts & Crafter
```

### 4. Maak een tijdschema voor de werknemers

Maak een tijdschema voor alle soorten activiteiten en slaag ze op in 1 list
/ array.  Zorg dat de activiteiten met een maximum volledig gebruikt worden
(indien mogelijk), en dat niemand overuren draait.

Print het tijdschema af, de klok begint te tellen vanaf 8 uur s'ochtends.

```
Dieren voederen:
  8u - 10u
  Jos Van de Velden

Boter maken:
  8u - 9u
  Mien de Cock

Beestjes haken:
  8u - 11u
  Amanda de Vlechter

Schapen scheren:
  10u - 12u
  Jos Van de Velden
```


### 5. Print af hoeveel kinderen er elk uur bezig gehouden worden.

Omdat deze metriek belangrijk is voor De Bonte Beestenboel willen we dit
voor elk uur ook afprinten.

Bij een onbeperkt aantal kinderen verwacht ik dat minsten 10 kinderen meedoen.

```
8 - 9u: 100 kinderen
9 - 10u: minstens 80 kinderen
...
15 - 16u: 150 kinderen
```

## Criteria

Deze opdrachgt is bvewust moeilijk gemaakt, er wordt dus niet gelet op hoe
efficient je algoritme is om mensen in te delen, maar het gebruik van OOP
concepten. Echter een 20/20 kan niet gescoord worden zonder efficient
algoritme.


Bij het printen van objecten verwacht ik dat de `.ToString()` operator gebruikt wordt.

















