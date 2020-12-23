# Gewens-Additional-Traits 
Gewen's-Additional-Traits updated to v1.0 Sourced from Swenzi's b18 update on the Steam Workshop

RimWorld version 1.1 removed some of the statdefs that this mod uses, I rather liked the traits that were affected and would hate to completely scrap them, as such I have reimplemented the removed statdefs in my [De-generalize Work mod](https://github.com/Alias44/Degeneralize-Work) as other modders seemed to be experiencing the same thing. De-generalize Work is **not** required for this mod and Additional Traits can and will function entirely without it, there will just be a few traits that are modified or don't show up at all.

## Installation Instructions

### To install a non-workshop RimWorld mod from zip download:
Click on the Clone or download button.
Click Download ZIP
Extract the zip to your RimWorld install folder (by windows default it's C:\Program Files (x86)\Steam\steamapps\common\RimWorld) and open the "Mods" folder.

After that run Rimworld and "Additional Traits" will show up in your mod list with a little folder icon next to it.
From there it should be just like any other workshop item

### To install using git:
Click on the Clone or download button.
Copy the url (https://github.com/Alias44/Gewens-Additional-Traits.git)
Open your preferred console (cmd, bash, etc).
cd into the mods directory. Default is C:\Program Files (x86)\Steam\steamapps\common\RimWorld\Mods
Enter the command git clone https://github.com/Alias44/Gewens-Additional-Traits.git
Note: You can get future changes by using the command get pull origin master

## Changes
Changelog:
v3.2.3
* 1.2 update
* Social penalty for pervert trait does not apply if both pawns have the pervert trait
* Harmony update (v2.0.2)

v3.2.2
* Patches that add nullifyingTraits to vanilla thoughts now check for the field before trying to add it (prevents '*X* defines the same field twice error)

v3.2.1
* Reenabled handling changes to def structure
* File enable/disable now behaves like a proper nested checkbox
* Removed duplicate changelog from about.xml
	
v3.2.0
* 1.1 update with 1.0 backwards compatibility
* Harmony update, the mod will include its own copy (v2.0.0.8), however it it recommended that you subscribe and activate the official [Harmony mod by Brrainz](https://github.com/pardeike/HarmonyRimWorld) so that you always have the latest version
* The following traits used statdefs that were removed by 1.1, as such they are now dependent on the [De-generalize Work mod](https://github.com/Alias44/Degeneralize-Work)
  * Natural Tailor
  * Eccentric Artist
* Vulcan's Fire now grants a much weaker +50% bonus to GeneralLaborSpeed instead of +100% to SmithingSpeed, unless De-generalize Work is loaded, in which case the trait is unchanged

v3.1.1
* Changed defNames to have a "GAT_" prefix to avoid/fix collisions with other mods that add traits
* Added harmony patch to handle the transition to the new defsNames

v3.1.0
* Added mod settings. Traits (or entire files of traits) can now be enabled or disabled from within the mod (a game reboot is required for changes to take effect (Please note that disabling any traits currently in use by your save will cause a \"Could not load reference to RimWorld.TraitDef named\" error on reload for each trait disabled. These errors can safely be dismissed and will not reoccur after saving again. Anyone that previously had a disabled trait will be randomly assigned a new one in its place.))
* Traits relabeled
  * Professional Butcher -> Natural Butcher
  * Professional Tailor -> Natural Tailor
  * Avid Artist -> Eccentric Artist
  * Mercurial -> Mercury's Blessing
  * Invulnerable -> 	Achillean
  * Goddess of Beauty -> Aphrodite's Grace
  * Odysseus -> Odyssean
  * God of war -> Ares' Wrath
  * Goddess of the hunt -> Artemis' Blessing
  * Smith of the Gods -> Vulcan's Fire
  * God of medicine -> Imhotep's Wisdom
  * Spirit of nature -> Sylvanus' Blessing
* Descriptions updated (incorrect parts of speech or other grammatical improvements)
  * Athletic
  * Dexterous
  * Genius Researcher
  * Green Thumb
  * Efficient Builder
  * Fast miner
  * Uncouth
* New Descriptions (the old ones are commented out in the xml files if for whatever reason there is a preference for them)
  * Careful Surgeon: NAM takes medicine very seriously. HE wants to do no harm and isn't afraid to take longer to do the job right.
  * Natural Butcher: Sometimes it's hard to tell where the knife stops and NAME starts. People like to say that "if it bleeds NAME can skin it and split it".
  * Natural Tailor: NAME likes making apparel. HE can work wonders with a needle and thread a hammer and anvil, not so much
  * Eccentric Artist: NAME is an eccentric artist. HE has an affinity for the arts, but HE often gets lost in HIS work and forget to take care of HIMself.
* Trait requirements 
  * Now requires that pawns are capable of violence
    * Perceptive
	 * Achillean
	 * Odyssean
	 * Ares' Wrath
	 * Artemis' Blessing
  * Now requires that pawns are capable of social (recruiting, trading, etc)
    * Persuasive
	 * Aphrodite's Grace
  * Now requires that pawns are capable of Artistic and PlantWork
    * Sylvanus' Blessing
  * Now requires that pawns are capable of Crafting and ManualSkilled
    * Vulcan's Fire
  * Now requires that pawns are capable of Caring
    * Imhotep's Wisdom
  * Trait Conflicts
    * Persuasive cannot be applied to pawns with TradePriceImprovementOffset traits (and vice versa)

v3.0.1
* Moved Heroes+Gods traits to a separate file for easy deletion by those that think they are over powered

v3.0 (by Alias)
* Updated to 1.0
* Diplomacy and Recruitment merged into NegotiationAbility
* Custom thought worker written for pervert (because ugly people aren't all perverts...)
* Cold-hearted trait removed (commented out) as it was a virtual clone of psychopath
* Healthy trait similarly removed for its similarity to super-immune
* Profession traits now require that the pawn be able to actually do the task related to the trait (no more shooting professionals that won't touch a gun)
* Similarly, shooting traits now conflict with brawler
* New trait: Morbid: Ashes to ashes and dust to dust. NAME is fascinated by corpses and decay
* Unnecessary clone of thoughtDefs removed and converted to xpath
* About rearranged to be more organized

v2.1 (by Swenzi)
* Updated to B18
* GiftImpact Offset changed to Diplomacy Power (GiftImpact stat was removed)
* Professional Stonecutter trait was removed (StonecuttingSpeed stat removed)

v2.0 (Professions and Heroes!)
* Careful Surgeon: NAME is a pretty good surgeon, but they takes a bit more time to complete an operation.
* Professional Stone Cutter: NAME likes to cut boulders down to size. Their stone cutting speed is greatly increased, but their lack of passion for other crafts slows them down.
* Professional Butcher: NAME likes dressing animals. Their butchering speed is greatly increased, but they're terrible with mechanoids.
* Professional Tailor: NAME likes making apparel. Their tailoring speed is greatly increased, but they're terrible with smithing.
* Loved By Animals: NAME is loved by animals, but people don't feel quite the same.
* Avid Artist: NAME is an avid artist. Their sculpting speed is greatly increased, but they have a weaker constitution and mind.
* Genius Researcher: Strange new ideas just appear in the mind of NAME. Researching new technology comes easily to NAME, but they always seem distracted.
* Greenest Thumb: NAME has a passion for gardening. They know exactly what a plant needs to grow happily.
* Efficient Builder: NAME doesn't like to waste materials. They take care in their work.
* Fast Miner: NAME knows how to exploit the cleavage of rocks. They don't understand why plants are so much more fragile, though.
* Hercules: Brave NAME, born with impossible strength and force of will.
* Mercury: It is said that NAME can leap the space between lightning and thunder, outfox the fox king, and reach tomorrow before the sun.
* Aphrodite: So wondrous is NAME to behold that one look can inspire tears, desire, jealousy, and love.
* Ares: Feared by his enemies and worshipped by warriors, NAME is a bloodthirsty God of War.
* Artemis: NAME's natural instinct to protect and nurture the people led HIM to champion the hunt.
* Vulcan: NAME crafts with fire and forge as an artist would with paint and brush.
* Imhotep: NAME sends to sleep those who suffer, the new day bringing good health to them.
* Sylvanus: Companion to all woodland creatures, both mundane and fantastic, NAME protects and nurtures those that respect HIS domain.
* Achilles: Said to have been dipped in the river of death, NAME seems invulnerable in battle.
* Odysseus: Craftier by far than any mortal man, NAME is also a very capable warrior.

v1.1 Traits:
* Cold-hearted: Lacks empathy, but more or less blends in with society.
* Pervert: Unaffected by nudity or sharing a bedroom with strangers. Creepy.
* Heavy sleeper: Unaffected by people stomping around next to them while they're sleeping.
* Introducing THOUGHTS!
* Traits now include mood and relationship impacting effects!

v1.0 (by Gewen) Traits:
* Confident: These pawns are more personable and have an increased break threshold
* Overweight: Works slower, walks slower.
* Athletic: Works quicker, walks quicker, aims a little better.
* Dexterous: Shorter trigger-pull delay, quicker worker. Good with crafts or arts.
* Perceptive: Improves accuracy.
* Clean: Healing quality goes up, and food prepared by these people have a reduced chance of being poisonous at the cost of some work speed.
* Near-sighted: Less accurate.
* Quick-learner: Learns quicker than the average person.
* Glutton: Eats quicker than the average person.
* Healthy: Recovers quicker from illness than the average person.
* Persuasive: Gets the edge in social performance (Trading, recruitment, etc.)
* Sucker: Gets suckered into selling for less, and buying for more.
* Amateur haggler: Gets slightly cheaper prices and sells for slightly higher.
* Haggling enthusiast: Gets much cheaper prices and sells for a lot more.
* Awkward: Fumbles through social interactions.
* Tucker: These pawns are a little more impactful with their words.
* Melodic: People love interacting with someone with a melodic voice.
* Uncouth diplomat: Other factions don't like receiving gifts from such an... uncouth person.
* Diplomatic: Gets a little more bang for his buck.
* Very diplomatic: Knows how to ease tension between factions with some Ag grease.
* Shooting amateur:Terrible at shooting. I really wouldn't give this guy a gun.
* Shooting enthusiast: This sharpshooter is worth his salt.
* Shooting professional: Rimworld Space Marines!

## Licensing
(From Gewens forum post, although I'm sure Swenzi and myself would like credit as well)

Feel free to tear this one apart to learn how traits are coded in XML or use it in a mod pack or whatever. Just give me some credit if you post the whole thing elsewhere, or a little tagline if I've inspired you somehow!
	
## Thanks
* [Gewen (Dennis)](url=https://steamcommunity.com/id/chinupinstantsexy)- Original author
* [Swenzi](url=https://steamcommunity.com/id/RulerFaust)- A17-B18 Maintainer
* The Rimworld Discord- for being wonderful people

## Links
* [Ludeon for more information](https://ludeon.com/forums/index.php?topic=29661.msg300431#msg300431])
* [Swenzi's B18 version of this mod](https://steamcommunity.com/sharedfiles/filedetails/?id=954490820)
* [Swenzi's B18 version without Heros + God](http://steamcommunity.com/sharedfiles/filedetails/?id=946944965)
* [The A17 version of this mod](https://github.com/yliankuo/Additional-Traits-w--Heroes---Gods)
* [Gewen's A16 original mod](http://steamcommunity.com/sharedfiles/filedetails/?id=851164051)
