using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Craft.Net.Data
{
    public class SoundEffect
    {
        // Generated from http://s3.amazonaws.com/MinecraftResources
        public const string AmbientCave = "ambient.cave.cave";
        public const string AmbientWeatherRain = "ambient.weather.rain";
        public const string AmbientWeatherThunder = "ambient.weather.thunder";
        public const string DamageFallBig = "damage.fallbig";
        public const string DamageFallSmall = "damage.fallsmall";
        public const string FireActive = "fire.fire";
        public const string FireIgnite = "fire.ignite";
        public const string LiquidLava = "liquid.lava";
        public const string LiquidLavaPop = "liquid.lavapop";
        public const string LiquidSplash = "liquid.splash";
        public const string LiquidWater = "liquid.water";
        public const string MobBlazeBreathe = "mob.blaze.breathe";
        public const string MobBlazeDeath = "mob.blaze.death";
        public const string MobBlazeHit = "mob.blaze.hit";
        public const string MobCatHiss = "mob.cat.hiss";
        public const string MobCatHitt = "mob.cat.hitt";
        public const string MobCatMeow = "mob.cat.meow";
        public const string MobCatPurr = "mob.cat.purr";
        public const string MobCatPurreow = "mob.cat.purreow";
        public const string MobChickenHurt = "mob.chicken.hurt";
        public const string MobChickenPlop = "mob.chicken.plop";
        public const string MobCowHurt = "mob.cow.hurt";
        public const string MobCreeper = "mob.creeper";
        public const string MobCreeperDeath = "mob.creeperdeath";
        public const string MobEndermenDeath = "mob.endermen.death";
        public const string MobEndermenHit = "mob.endermen.hit";
        public const string MobEndermenIdle = "mob.endermen.idle";
        public const string MobEndermenPortal = "mob.endermen.portal";
        public const string MobEndermenScream = "mob.endermen.scream";
        public const string MobEndermenStare = "mob.endermen.stare";
        public const string MobGhastAffectionateScream = "mob.ghast.affectionate scream";
        public const string MobGhastCharge = "mob.ghast.charge";
        public const string MobGhastDeath = "mob.ghast.death";
        public const string MobGhastFireball = "mob.ghast.fireball";
        public const string MobGhastMoan = "mob.ghast.moan";
        public const string MobGhastScream = "mob.ghast.scream";
        public const string MobIrongolemDeath = "mob.irongolem.death";
        public const string MobIrongolemHit = "mob.irongolem.hit";
        public const string MobIrongolemThrow = "mob.irongolem.throw";
        public const string MobIrongolemWalk = "mob.irongolem.walk";
        public const string MobMagmacubeBig = "mob.magmacube.big";
        public const string MobMagmacubeJump = "mob.magmacube.jump";
        public const string MobMagmacubeSmall = "mob.magmacube.small";
        public const string MobPigdeath = "mob.pig.death";
        public const string MobSilverfishHit = "mob.silverfish.hit";
        public const string MobSilverfishKill = "mob.silverfish.kill";
        public const string MobSilverfishSay = "mob.silverfish.say";
        public const string MobSilverfishStep = "mob.silverfish.step";
        public const string MobSkeletonDeath = "mob.skeleton.death";
        public const string MobSkeletonHurt = "mob.skeleton.hurt";
        public const string MobSlimeattack = "mob.slime.attack";
        public const string MobSpiderDeath = "mob.spider.death";
        public const string MobWolfBark = "mob.wolf.bark";
        public const string MobWolfDeath = "mob.wolf.death";
        public const string MobWolfGrowl = "mob.wolf.growl";
        public const string MobWolfHowl = "mob.wolf.howl";
        public const string MobWolfHurt = "mob.wolf.hurt";
        public const string MobWolfPanting = "mob.wolf.panting";
        public const string MobWolfShake = "mob.wolf.shake";
        public const string MobWolfWhine = "mob.wolf.whine";
        public const string MobZombieMetal = "mob.zombie.metal";
        public const string MobZombieWood = "mob.zombie.wood";
        public const string MobZombieWoodbreak = "mob.zombie.woodbreak";
        public const string MobZombie = "mob.zombie";
        public const string MobZombiedeath = "mob.zombie.death";
        public const string MobZombiehurt = "mob.zombie.hurt";
        public const string MobZombiepigZpig = "mob.zombiepig.zpig";
        public const string MobZombiepigZpigangry = "mob.zombiepig.zpigangry";
        public const string MobZombiepigZpigdeath = "mob.zombiepig.zpigdeath";
        public const string MobZombiepigZpighurt = "mob.zombiepig.zpighurt";
        public const string NoteBass = "note.bass";
        public const string NoteBassAttack = "note.bassattack";
        public const string NoteBd = "note.bd";
        public const string NoteHarp = "note.harp";
        public const string NoteHat = "note.hat";
        public const string NotePling = "note.pling";
        public const string NoteSnare = "note.snare";
        public const string PortalNear = "portal.portal";
        public const string PortalTravel = "portal.travel";
        public const string PortalTrigger = "portal.trigger";
        public const string RandomBow = "random.bow";
        public const string RandomBowhit = "random.bowhit";
        public const string RandomBreak = "random.break";
        public const string RandomBreath = "random.breath";
        public const string RandomBurp = "random.burp";
        public const string RandomChestclosed = "random.chestclosed";
        public const string RandomChestopen = "random.chestopen";
        public const string RandomClick = "random.click";
        public const string RandomDoorClose = "random.door_close";
        public const string RandomDoorOpen = "random.door_open";
        public const string RandomDrink = "random.drink";
        public const string RandomEat = "random.eat";
        public const string RandomExplode = "random.explode";
        public const string RandomFizz = "random.fizz";
        public const string RandomFuse = "random.fuse";
        public const string RandomGlass = "random.glass";
        public const string RandomLevelup = "random.levelup";
        public const string RandomOldExplode = "random.old_explode";
        public const string RandomOrb = "random.orb";
        public const string RandomPop = "random.pop";
        public const string RandomSplash = "random.splash";
        public const string RandomWoodClick = "random.wood click";
        public const string StepCloth = "step.cloth";
        public const string StepGrass = "step.grass";
        public const string StepGravel = "step.gravel";
        public const string StepSand = "step.sand";
        public const string StepSnow = "step.snow";
        public const string StepStone = "step.stone";
        public const string StepWood = "step.wood";
        public const string TilePistonIn = "tile.piston.in";
        public const string TilePistonOut = "tile.piston.out";
        public const string DamageHit = "damage.hit";
        public const string DigCloth = "dig.cloth";
        public const string DigGrass = "dig.grass";
        public const string DigGravel = "dig.gravel";
        public const string DigSand = "dig.sand";
        public const string DigSnow = "dig.snow";
        public const string DigStone = "dig.stone";
        public const string DigWood = "dig.wood";
        public const string LiquidSwim = "liquid.swim";
        public const string MinecartBase = "minecart.base";
        public const string MinecartInside = "minecart.inside";
        public const string MobChickenSay = "mob.chicken.say";
        public const string MobChickenStep = "mob.chicken.step";
        public const string MobCowSay = "mob.cow.say";
        public const string MobCowStep = "mob.cow.step";
        public const string MobCreeperSay = "mob.creeper.say";
        public const string MobPigDeath = "mob.pig.death";
        public const string MobPigSay = "mob.pig.say";
        public const string MobPigStep = "mob.pig.step";
        public const string MobSheepSay = "mob.sheep.say";
        public const string MobSheepShear = "mob.sheep.shear";
        public const string MobSheepStep = "mob.sheep.step";
        public const string MobSkeletonSay = "mob.skeleton.say";
        public const string MobSkeletonStep = "mob.skeleton.step";
        public const string MobSlimeAttack = "mob.slime.attack";
        public const string MobSlimeBig = "mob.slime.big";
        public const string MobSlimeSmall = "mob.slime.small";
        public const string MobSpiderSay = "mob.spider.say";
        public const string MobSpiderStep = "mob.spider.step";
        public const string MobWolfStep = "mob.wolf.step";
        public const string MobZombieDeath = "mob.zombie.death";
        public const string MobZombieHurt = "mob.zombie.hurt";
        public const string MobZombieSay = "mob.zombie.say";
        public const string MobZombieStep = "mob.zombie.step";
        public const string RandomClassicHurt = "random.classic_hurt";
        public const string StepLadder = "step.ladder";
    }
}
