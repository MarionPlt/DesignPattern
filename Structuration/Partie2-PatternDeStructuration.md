# 1) Adapter

C'est un design pattern qui permet de faire collaborer des objets ayant des interfaces normalement incompatibles.  
**But =>** convertir l'interface d'une classe donnée en une interface attendue par des clients afin qu'ils puissent
travailler ensemble.

![](adapter.png)  
DocumentHtml hérite de Document. DocumentPdf hérite de Document et est composé de plusieurs objets ComposantPdf. Dans ce
cas, la classe DocumentPdf adapte ComposantPdf.  
*voir exemple d'implémentation dans dossier Adapter*

# 2) Bridge