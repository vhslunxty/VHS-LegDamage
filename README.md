# VHS-LegDamage

[![Framework](https://img.shields.io/badge/Framework-EXILED-red.svg)](https://github.com/Exiled-Team/EXILED)
![Version](https://img.shields.io/badge/Version-1.0.0-blue.svg)

**LegDamagePlugin-SL** est un plugin pour les serveurs **SCP: Secret Laboratory** qui ajoute une gestion personnalisée des dégâts infligés aux jambes des joueurs. Idéal pour renforcer l'immersion ou ajuster l'équilibrage des chutes et des combats.

## ✨ Fonctionnalités

* **Dégâts de chute personnalisés :** Modifiez l'impact des chutes sur la santé des joueurs.
* **Effets de statut :** Possibilité d'infliger automatiquement l'effet "Fracture" (Disabled/Leged) selon la hauteur de chute.
* **Configuration flexible :** Ajustez chaque paramètre via le fichier de configuration standard d'EXILED.
* **Compatibilité :** Conçu pour fonctionner avec la dernière version d'EXILED.
* 
## ⚙️ Configuration

Une fois le plugin lancé une première fois, un fichier de configuration sera généré. Voici un exemple des paramètres disponibles :

```yml
leg_damage:
  is_enabled: true
  # Multiplicateur de dégâts de chute
  fall_damage_multiplier: 1.5
  # Hauteur minimale pour infliger l'effet "Fracture"
  min_height_for_fracture: 10
  # Liste des rôles ignorés par le plugin
  ignored_roles:
    - Scp173
    - Scp106
```
