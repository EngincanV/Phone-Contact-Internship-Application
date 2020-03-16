<!-- PROJECT SHIELDS -->
[![Build Status][build-shield]]()
[![Contributors][contributors-shield]]()
[![MIT License][license-shield]][license-url]
[![LinkedIn][linkedin-shield]][linkedin-url]
![Twitter][twitter-shield]

<br />
<p align="center">
  <h3 align="center">Nuevo - Phone Contact</h3>
  <p align="center">
    This application was created for internship apply to Nuevo.
  </p>
</p>

<!-- Contents -->
## Contents

* [About Project](#about-project)
  * [Purpose Of Project](#purpose-of-project)
* [Installation](#installation)

## About Project
This application was created for internship apply to Nuevo.

| Technologies | Version
| --- | ---
| Asp.net Core | 3.1
| Entity Framework Core | 3.1
| Sql Server | 2019

### Purpose Of Project
* System has two different interfaces.
* Public interface that everybody can see(PublicUI)
* Private interface that just Admins can see(PrivateUI)
* In PublicUI you can just see information(Personal Name, Personal Phone Number) about personals.
* In AdminUI you can add, edit or delete personals. Only condition is here, for deleting any specific personal we need to be his manager.
* Departmens which are exist in system will be manageable. Adding, Editing and Deleting departments can be done by Admins. For deleting any specific department, the department must not have any personal.

## Installation
1. Clone the repository.
```sh
git clone https://github.com/EngincanV/Phone-Contact-Internship-Application.git
```
2. Install npm packages.
```sh
npm install
```
3. Run the app.
```sh
npm start or yarn start
```

<!-- MARKDOWN LINKS & IMAGES -->
[build-shield]: https://img.shields.io/badge/build-passing-brightgreen.svg?style=flat-square
[contributors-shield]: https://img.shields.io/badge/contributors-1-orange.svg?style=flat-square
[license-shield]: https://img.shields.io/badge/license-MIT-blue.svg?style=flat-square
[license-url]: https://choosealicense.com/licenses/mit
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=flat-square&logo=linkedin&colorB=555
[linkedin-url]: https://www.linkedin.com/in/engincan-veske-b4a75b145/
[twitter-shield]: https://img.shields.io/twitter/follow/EngincanVeske?label=Twitter&style=social
