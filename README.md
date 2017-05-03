#Sitecore Habitat

Habitat is a Sitecore solution example built on a modular architecture.
The architecture and methodology focuses on:

* Simplicity - *A consistent and discoverable architecture*
* Flexibility - *Change and add quickly and without worry*
* Extensibility - *Simply add new features without steep learning curve*

For more information, please check out the [Habitat Wiki](../../wiki)

## Fortis

This branch is a fork of the original Habitat (on Sitecore 8.2 Update 1) that has been updated to integrate with Fortis. Note that a upgraded version that works with Sitecore 8.2 Update 3 is also available, see feature/fortis-integration-sc82u3 if needed.

A Fortis foundation module has been added in and it is responsible for:

* Fortis model code generation using T4 template (CodeGen\CodeGen.tt and CodeGen\Fortis\Fortis.t4) - this generates the interfaces and concret classes as well as a constants struct to allow accessing template ID, field ID and name when needed.
* Fortis startup registration

### What the fork will not do (for the moment)?

As Habitat has a already-working generic search implementation and it works pretty well so there is no intention to update or create a Fortis version of the search engine / providers. For the ones who are interested, Fortis also supports Sitecore search via either Fortis.Search.Lucene or Fortis.Search.Solr which you could try to update the Sitecore.Foundation.Indexing module to work with it.

### Progress
All modules are now using Fortis (except anything that is utilising the search functionalities mentioned above, ah, and the way the dynamic teaser is done in the Teasers module).
