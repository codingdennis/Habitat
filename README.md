#Sitecore Habitat

Habitat is a Sitecore solution example built on a modular architecture.
The architecture and methodology focuses on:

* Simplicity - *A consistent and discoverable architecture*
* Flexibility - *Change and add quickly and without worry*
* Extensibility - *Simply add new features without steep learning curve*

For more information, please check out the [Habitat Wiki](../../wiki)

#Fortis

This branch is a fork of the original Habitat that has been updated to integrate with Fortis. A Fortis foundation module has been added in and it is responsible for:

* Fortis model code generation using T4 template (CodeGen\CodeGen.tt and CodeGen\Fortis\Fortis.t4) - this generates the interfaces and concret classes as well as a constants struct to allow accessing template ID, field ID and name when needed.
* Fortis startup registration

Note that this is still ongoing. At the moment the following features are converted to use Fortis:

* Feature\Accounts
* Feature\Demo
* Feature\FAQ
* Feature\Identity
* Feature\Language
* Feature\Maps
* Feature\Media
* Feature\Metadata
* Feature\Multisite
* Feature\Navigation

Modules not mentioned here are in progress.
