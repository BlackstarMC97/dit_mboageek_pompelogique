# MboaGeek Pompe Simulator - Logiciel de simulation du fonctionnement d'une pompe à essence. Basé sur prolog.

## Enoncé du problème
On veut commander une pompe à l'aide de deux boutons poussoirs (Marche-Arrêt). Réaliser le circuit à deux entrées M/A et 
une sortie P tel que : 

En appuyant sur M : 
- Si la pompe est arrêtée, elle démarre et continue à tourner lorsqu'on lâche le bouton M
- Si la pompe fonctionne, elle continue à fonctionner

En appuyant sur A : 
- Si la pompe fonctionne, elle s'arrête et reste arrêtée lorsqu'on lâche le bouton A
- Si la pompe est arrêtée, elle démeure arrêtée

## Méthode de résolution
Pour résoudre notre problème, on utilisera une table de vérité que l'on essayera de traduire en expression logique à 
partir d'une table de Karnaugh, c'est simple :smile:

### TABLE DE VERITE

M | A | P | S
---- | ---- | ---- | ----
0 | 0 | 0 | 0
0 | 0 | 1 | 1
0 | 1 | 0 | 0
0 | 1 | 1 | 0
1 | 0 | 0 | 1
1 | 0 | 1 | 1
1 | 1 | 0 | 0
1 | 1 | 1 | 1


## Schéma logique du circuit
Le schéma logique du circuit final est le suivant : 

![Image du circuitLogique](https://raw.githubusercontent.com/BlackstarMC97/dit_mboageek_pompelogique/master/PompeEssence%20Logique/bin/pompesim1.JPG)

## Aperçu du logiciel de simulation
