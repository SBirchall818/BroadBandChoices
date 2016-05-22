# BroadBandChoices
A repository for the BroadBandChoices programming test

# JumpStart

The BasketUI solution contains a BasketUI Windows Forms project that can be used to drive the basket.
The logic for the basket is contained within a Class Library project called BasketLogic.
Each project has a corresponding test project called BasketUITests and BasketLogicTests respectively.

# Environment

All projects are built against .NET Framework v4.5.2.
The solution was developed in Visual Studio Community 2015 version 14.0.25123.00 Update 2

# Assumptions Made

* Only 1 offer can apply to a type of basket item.
* All currency is in GBP

Offers cannot compound and can be applied in any order as a consequence of the above.

# Comments on Style
This task has adopted a TDD and SOLID approach.
If I were to be assigned this task in a production environment I would programme more defensively. I have chosen not to programme defensively during this exercise to prevent obfuscating the design and cluttering the codebase.

# Proposed further work
* Display how much money was saved due to offers
* Show that an item is available at a discount because of other items in basket
* Test mode where offers can be enabled and disabled.
* Make UI adaptable to changing inventory of items
* Create a Money class to encapsulate the storing of monetary values in memory, operations on those values and presentation of currency.
* Investigation of edge cases and requesting an accepted upper limit on basket content from product owners.
