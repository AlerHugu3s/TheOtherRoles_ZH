using System.Collections.Generic;
using UnityEngine;
using static TheOtherRoles.TheOtherRoles;
using Types = TheOtherRoles.CustomOption.CustomOptionType;

namespace TheOtherRoles {
    public class CustomOptionHolder {
        public static string[] rates = new string[]{"0%", "10%", "20%", "30%", "40%", "50%", "60%", "70%", "80%", "90%", "100%"};
        public static string[] ratesModifier = new string[]{"1", "2", "3"};
        public static string[] presets = new string[]{"预设 1", "预设 2", "预设 3", "预设 4", "预设 5"};
        
        public static CustomOption presetSelection;
        public static CustomOption activateRoles;
        public static CustomOption crewmateRolesCountMin;
        public static CustomOption crewmateRolesCountMax;
        public static CustomOption neutralRolesCountMin;
        public static CustomOption neutralRolesCountMax;
        public static CustomOption impostorRolesCountMin;
        public static CustomOption impostorRolesCountMax;
        public static CustomOption modifiersCountMin;
        public static CustomOption modifiersCountMax;

        public static CustomOption soliderSpawnRate;
        public static CustomOption bulletProofDisappearLatency;

        public static CustomOption positionShifterSpawnRate;
        public static CustomOption positionShiftCooldown;

        public static CustomOption mafiaSpawnRate;
        public static CustomOption janitorCooldown;

        public static CustomOption morphlingSpawnRate;
        public static CustomOption morphlingCooldown;
        public static CustomOption morphlingDuration;

        public static CustomOption camouflagerSpawnRate;
        public static CustomOption camouflagerCooldown;
        public static CustomOption camouflagerDuration;

        public static CustomOption vampireSpawnRate;
        public static CustomOption vampireKillDelay;
        public static CustomOption vampireCooldown;
        public static CustomOption vampireCanKillNearGarlics;

        public static CustomOption eraserSpawnRate;
        public static CustomOption eraserCooldown;
        public static CustomOption eraserCanEraseAnyone;
        public static CustomOption guesserSpawnRate;
        public static CustomOption guesserIsImpGuesserRate;
        public static CustomOption guesserNumberOfShots;
        public static CustomOption guesserHasMultipleShotsPerMeeting;
        public static CustomOption guesserShowInfoInGhostChat;
        public static CustomOption guesserKillsThroughShield;
        public static CustomOption guesserEvilCanKillSpy;
        public static CustomOption guesserSpawnBothRate;
        public static CustomOption guesserCantGuessSnitchIfTaksDone;

        public static CustomOption jesterSpawnRate;
        public static CustomOption jesterCanCallEmergency;
        public static CustomOption jesterHasImpostorVision;

        public static CustomOption arsonistSpawnRate;
        public static CustomOption arsonistCooldown;
        public static CustomOption arsonistDuration;

        public static CustomOption jackalSpawnRate;
        public static CustomOption jackalKillCooldown;
        public static CustomOption jackalCreateSidekickCooldown;
        public static CustomOption jackalCanUseVents;
        public static CustomOption jackalCanCreateSidekick;
        public static CustomOption sidekickPromotesToJackal;
        public static CustomOption sidekickCanKill;
        public static CustomOption sidekickCanUseVents;
        public static CustomOption jackalPromotedFromSidekickCanCreateSidekick;
        public static CustomOption jackalCanCreateSidekickFromImpostor;
        public static CustomOption jackalAndSidekickHaveImpostorVision;

        public static CustomOption bountyHunterSpawnRate;
        public static CustomOption bountyHunterBountyDuration;
        public static CustomOption bountyHunterReducedCooldown;
        public static CustomOption bountyHunterPunishmentTime;
        public static CustomOption bountyHunterShowArrow;
        public static CustomOption bountyHunterArrowUpdateIntervall;

        public static CustomOption witchSpawnRate;
        public static CustomOption witchCooldown;
        public static CustomOption witchAdditionalCooldown;
        public static CustomOption witchCanSpellAnyone;
        public static CustomOption witchSpellCastingDuration;
        public static CustomOption witchTriggerBothCooldowns;
        public static CustomOption witchVoteSavesTargets;

        public static CustomOption ninjaSpawnRate;
        public static CustomOption ninjaCooldown;
        public static CustomOption ninjaKnowsTargetLocation;
        public static CustomOption ninjaTraceTime;
        public static CustomOption ninjaTraceColorTime;
        public static CustomOption ninjaInvisibleDuration;

        public static CustomOption shifterSpawnRate;
        public static CustomOption shifterShiftsModifiers;

        public static CustomOption mayorSpawnRate;
        public static CustomOption mayorCanSeeVoteColors;
        public static CustomOption mayorTasksNeededToSeeVoteColors;
        public static CustomOption mayorMeetingButton;
        public static CustomOption mayorMaxRemoteMeetings;

        public static CustomOption portalmakerSpawnRate;
        public static CustomOption portalmakerCooldown;
        public static CustomOption portalmakerUsePortalCooldown;
        public static CustomOption portalmakerLogOnlyColorType;
        public static CustomOption portalmakerLogHasTime;

        public static CustomOption engineerSpawnRate;
        public static CustomOption engineerNumberOfFixes;
        public static CustomOption engineerHighlightForImpostors;
        public static CustomOption engineerHighlightForTeamJackal;

        public static CustomOption sheriffSpawnRate;
        public static CustomOption sheriffCooldown;
        public static CustomOption sheriffCanKillNeutrals;
        public static CustomOption deputySpawnRate;

        public static CustomOption deputyNumberOfHandcuffs;
        public static CustomOption deputyHandcuffCooldown;
        public static CustomOption deputyGetsPromoted;
        public static CustomOption deputyKeepsHandcuffs;
        public static CustomOption deputyHandcuffDuration;
        public static CustomOption deputyKnowsSheriff;

        public static CustomOption lighterSpawnRate;
        public static CustomOption lighterModeLightsOnVision;
        public static CustomOption lighterModeLightsOffVision;
        public static CustomOption lighterCooldown;
        public static CustomOption lighterDuration;

        public static CustomOption detectiveSpawnRate;
        public static CustomOption detectiveAnonymousFootprints;
        public static CustomOption detectiveFootprintIntervall;
        public static CustomOption detectiveFootprintDuration;
        public static CustomOption detectiveReportNameDuration;
        public static CustomOption detectiveReportColorDuration;

        public static CustomOption timeMasterSpawnRate;
        public static CustomOption timeMasterCooldown;
        public static CustomOption timeMasterRewindTime;
        public static CustomOption timeMasterShieldDuration;

        public static CustomOption medicSpawnRate;
        public static CustomOption medicShowShielded;
        public static CustomOption medicShowAttemptToShielded;
        public static CustomOption medicSetOrShowShieldAfterMeeting;
        public static CustomOption medicShowAttemptToMedic;
        public static CustomOption medicSetShieldAfterMeeting;

        public static CustomOption swapperSpawnRate;
        public static CustomOption swapperCanCallEmergency;
        public static CustomOption swapperCanOnlySwapOthers;
        public static CustomOption swapperSwapsNumber;
        public static CustomOption swapperRechargeTasksNumber;

        public static CustomOption seerSpawnRate;
        public static CustomOption seerMode;
        public static CustomOption seerSoulDuration;
        public static CustomOption seerLimitSoulDuration;

        public static CustomOption hackerSpawnRate;
        public static CustomOption hackerCooldown;
        public static CustomOption hackerHackeringDuration;
        public static CustomOption hackerOnlyColorType;
        public static CustomOption hackerToolsNumber;
        public static CustomOption hackerRechargeTasksNumber;
        public static CustomOption hackerNoMove;

        public static CustomOption trackerSpawnRate;
        public static CustomOption trackerUpdateIntervall;
        public static CustomOption trackerResetTargetAfterMeeting;
        public static CustomOption trackerCanTrackCorpses;
        public static CustomOption trackerCorpsesTrackingCooldown;
        public static CustomOption trackerCorpsesTrackingDuration;

        public static CustomOption snitchSpawnRate;
        public static CustomOption snitchLeftTasksForReveal;
        public static CustomOption snitchIncludeTeamJackal;
        public static CustomOption snitchTeamJackalUseDifferentArrowColor;

        public static CustomOption spySpawnRate;
        public static CustomOption spyCanDieToSheriff;
        public static CustomOption spyImpostorsCanKillAnyone;
        public static CustomOption spyCanEnterVents;
        public static CustomOption spyHasImpostorVision;

        public static CustomOption tricksterSpawnRate;
        public static CustomOption tricksterPlaceBoxCooldown;
        public static CustomOption tricksterLightsOutCooldown;
        public static CustomOption tricksterLightsOutDuration;

        public static CustomOption cleanerSpawnRate;
        public static CustomOption cleanerCooldown;
        
        public static CustomOption warlockSpawnRate;
        public static CustomOption warlockCooldown;
        public static CustomOption warlockRootTime;

        public static CustomOption securityGuardSpawnRate;
        public static CustomOption securityGuardCooldown;
        public static CustomOption securityGuardTotalScrews;
        public static CustomOption securityGuardCamPrice;
        public static CustomOption securityGuardVentPrice;
        public static CustomOption securityGuardCamDuration;
        public static CustomOption securityGuardCamMaxCharges;
        public static CustomOption securityGuardCamRechargeTasksNumber;
        public static CustomOption securityGuardNoMove;

        public static CustomOption vultureSpawnRate;
        public static CustomOption vultureCooldown;
        public static CustomOption vultureNumberToWin;
        public static CustomOption vultureCanUseVents;
        public static CustomOption vultureShowArrows;

        public static CustomOption mediumSpawnRate;
        public static CustomOption mediumCooldown;
        public static CustomOption mediumDuration;
        public static CustomOption mediumOneTimeUse;

        public static CustomOption lawyerSpawnRate;
        public static CustomOption lawyerTargetCanBeJester;
        public static CustomOption lawyerVision;
        public static CustomOption lawyerKnowsRole;
        public static CustomOption pursuerCooldown;
        public static CustomOption pursuerBlanksNumber;

        public static CustomOption modifierBait;
        public static CustomOption modifierBaitQuantity;
        public static CustomOption modifierBaitReportDelayMin;
        public static CustomOption modifierBaitReportDelayMax;
        public static CustomOption modifierBaitShowKillFlash;

        public static CustomOption modifierLover;
        public static CustomOption modifierLoverImpLoverRate;
        public static CustomOption modifierLoverBothDie;
        public static CustomOption modifierLoverEnableChat;

        public static CustomOption modifierBloody;
        public static CustomOption modifierBloodyQuantity;
        public static CustomOption modifierBloodyDuration;

        public static CustomOption modifierAntiTeleport;
        public static CustomOption modifierAntiTeleportQuantity;

        public static CustomOption modifierTieBreaker;

        public static CustomOption modifierSunglasses;
        public static CustomOption modifierSunglassesQuantity;
        public static CustomOption modifierSunglassesVision;
        
        public static CustomOption modifierMini;
        public static CustomOption modifierMiniGrowingUpDuration;

        public static CustomOption modifierVip;
        public static CustomOption modifierVipQuantity;
        public static CustomOption modifierVipShowColor;

        public static CustomOption modifierInvert;
        public static CustomOption modifierInvertQuantity;
        public static CustomOption modifierInvertDuration;
        
        public static CustomOption maxNumberOfMeetings;
        public static CustomOption blockSkippingInEmergencyMeetings;
        public static CustomOption noVoteIsSelfVote;
        public static CustomOption hidePlayerNames;
        public static CustomOption allowParallelMedBayScans;
        public static CustomOption shieldFirstKill;

        public static CustomOption dynamicMap;
        public static CustomOption dynamicMapEnableSkeld;
        public static CustomOption dynamicMapEnableMira;
        public static CustomOption dynamicMapEnablePolus;
        public static CustomOption dynamicMapEnableAirShip;
        public static CustomOption dynamicMapEnableSubmerged;

        public static CustomOption vigilanteSpawnRate;
        public static CustomOption vigilanteCooldown;

        internal static Dictionary<byte, byte[]> blockedRolePairings = new Dictionary<byte, byte[]>();

        public static string cs(Color c, string s) {
            return string.Format("<color=#{0:X2}{1:X2}{2:X2}{3:X2}>{4}</color>", ToByte(c.r), ToByte(c.g), ToByte(c.b), ToByte(c.a), s);
        }
 
        private static byte ToByte(float f) {
            f = Mathf.Clamp01(f);
            return (byte)(f * 255);
        }

        public static void Load() {
            
            
            // Role Options
            
            presetSelection = CustomOption.Create(0,Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "预设"), presets, null, true);
            activateRoles = CustomOption.Create(1,Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "激活模组并禁用原版角色"), true, null, true);

            // Using new id's for the options to not break compatibilty with older versions
            crewmateRolesCountMin = CustomOption.Create(300,Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "最小船员数量"), 0f, 0f, 15f, 1f, null, true);
            crewmateRolesCountMax = CustomOption.Create(301,Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "最大船员数量"), 0f, 0f, 15f, 1f);
            neutralRolesCountMin = CustomOption.Create(302,Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "最小中立数量"), 0f, 0f, 15f, 1f);
            neutralRolesCountMax = CustomOption.Create(303,Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "最大中立数量"), 0f, 0f, 15f, 1f);
            impostorRolesCountMin = CustomOption.Create(304,Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "最小内鬼数量"), 0f, 0f, 3f, 1f);
            impostorRolesCountMax = CustomOption.Create(305,Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "最大内鬼数量"), 0f, 0f, 3f, 1f);
            modifiersCountMin = CustomOption.Create(306, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "最小额外角色数量"), 0f, 0f, 15f, 1f);
            modifiersCountMax = CustomOption.Create(307, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "最大额外角色数量"), 0f, 0f, 15f, 1f);

            mafiaSpawnRate = CustomOption.Create(10,Types.Impostor, cs(Janitor.color, "黑手党生成概率"), rates, null, true);
            janitorCooldown = CustomOption.Create(11,Types.Impostor, "清洁工冷却", 30f, 10f, 60f, 2.5f, mafiaSpawnRate);

            morphlingSpawnRate = CustomOption.Create(20,Types.Impostor, cs(Morphling.color, "化形者生成概率"), rates, null, true);
            morphlingCooldown = CustomOption.Create(21,Types.Impostor, "化形技能冷却", 30f, 10f, 60f, 2.5f, morphlingSpawnRate);
            morphlingDuration = CustomOption.Create(22,Types.Impostor, "化形持续时长", 10f, 1f, 20f, 0.5f, morphlingSpawnRate);

            camouflagerSpawnRate = CustomOption.Create(30,Types.Impostor, cs(Camouflager.color, "伪装者生成概率"), rates, null, true);
            camouflagerCooldown = CustomOption.Create(31,Types.Impostor, "伪装技能冷却", 30f, 10f, 60f, 2.5f, camouflagerSpawnRate);
            camouflagerDuration = CustomOption.Create(32,Types.Impostor, "伪装持续时长", 10f, 1f, 20f, 0.5f, camouflagerSpawnRate);

            vampireSpawnRate = CustomOption.Create(40,Types.Impostor, cs(Vampire.color, "吸血鬼生成概率"), rates, null, true);
            vampireKillDelay = CustomOption.Create(41,Types.Impostor, "吸血鬼杀人延迟", 10f, 1f, 20f, 1f, vampireSpawnRate);
            vampireCooldown = CustomOption.Create(42,Types.Impostor, "吸血鬼咬人冷却", 30f, 10f, 60f, 2.5f, vampireSpawnRate);
            vampireCanKillNearGarlics = CustomOption.Create(43,Types.Impostor, "吸血鬼可以在大蒜附近击杀", true, vampireSpawnRate);

            eraserSpawnRate = CustomOption.Create(230,Types.Impostor, cs(Eraser.color, "抹除者生成概率"), rates, null, true);
            eraserCooldown = CustomOption.Create(231,Types.Impostor, "抹除技能冷却", 30f, 10f, 120f, 5f, eraserSpawnRate);
            eraserCanEraseAnyone = CustomOption.Create(232,Types.Impostor, "抹除者可抹除任何角色", false, eraserSpawnRate);

            tricksterSpawnRate = CustomOption.Create(250,Types.Impostor, cs(Trickster.color, "诡术师生成概率"), rates, null, true);
            tricksterPlaceBoxCooldown = CustomOption.Create(251,Types.Impostor, "诡计盒冷却", 10f, 2.5f, 30f, 2.5f, tricksterSpawnRate);
            tricksterLightsOutCooldown = CustomOption.Create(252,Types.Impostor, "诡术师关灯冷却时间", 30f, 10f, 60f, 5f, tricksterSpawnRate);
            tricksterLightsOutDuration = CustomOption.Create(253,Types.Impostor, "诡术师关灯持续时间", 15f, 5f, 60f, 2.5f, tricksterSpawnRate);

            cleanerSpawnRate = CustomOption.Create(260,Types.Impostor, cs(Cleaner.color, "清理者生成概率"), rates, null, true);
            cleanerCooldown = CustomOption.Create(261,Types.Impostor, "清理技能冷却", 30f, 10f, 60f, 2.5f, cleanerSpawnRate);

            warlockSpawnRate = CustomOption.Create(270,Types.Impostor, cs(Cleaner.color, "术士生成概率"), rates, null, true);
            warlockCooldown = CustomOption.Create(271,Types.Impostor, "咒术技能冷却", 30f, 10f, 60f, 2.5f, warlockSpawnRate);
            warlockRootTime = CustomOption.Create(272,Types.Impostor, "咒术定身时长", 5f, 0f, 15f, 1f, warlockSpawnRate);

            bountyHunterSpawnRate = CustomOption.Create(320,Types.Impostor, cs(BountyHunter.color, "赏金猎人生成概率"), rates, null, true);
            bountyHunterBountyDuration = CustomOption.Create(321,Types.Impostor, "赏金目标改变间隔时长",  60f, 10f, 180f, 10f, bountyHunterSpawnRate);
            bountyHunterReducedCooldown = CustomOption.Create(322,Types.Impostor, "杀死赏金目标后的击杀冷却时长", 2.5f, 0f, 30f, 2.5f, bountyHunterSpawnRate);
            bountyHunterPunishmentTime = CustomOption.Create(323,Types.Impostor, "击杀非赏金目标后的额外冷却时长", 20f, 0f, 60f, 2.5f, bountyHunterSpawnRate);
            bountyHunterShowArrow = CustomOption.Create(324,Types.Impostor, "显示指向赏金目标的箭头", true, bountyHunterSpawnRate);
            bountyHunterArrowUpdateIntervall = CustomOption.Create(325,Types.Impostor, "箭头更新间隔", 15f, 2.5f, 60f, 2.5f, bountyHunterShowArrow);

            witchSpawnRate = CustomOption.Create(370,Types.Impostor, cs(Witch.color, "女巫生成概率"), rates, null, true);
            witchCooldown = CustomOption.Create(371,Types.Impostor, "女巫施咒冷却", 30f, 10f, 120f, 5f, witchSpawnRate);
            witchAdditionalCooldown = CustomOption.Create(372,Types.Impostor, "女巫额外冷却", 10f, 0f, 60f, 5f, witchSpawnRate);
            witchCanSpellAnyone = CustomOption.Create(373,Types.Impostor, "女巫可对任何人施咒", false, witchSpawnRate);
            witchSpellCastingDuration = CustomOption.Create(374,Types.Impostor, "施咒持续时间", 1f, 0f, 10f, 1f, witchSpawnRate);
            witchTriggerBothCooldowns = CustomOption.Create(375,Types.Impostor, "施咒与击杀共用冷却", true, witchSpawnRate);
            witchVoteSavesTargets = CustomOption.Create(376,Types.Impostor, "将女巫投出可拯救被施咒人", true, witchSpawnRate);

            ninjaSpawnRate = CustomOption.Create(380, Types.Impostor, cs(Ninja.color, "忍者生成概率"), rates, null, true);
            ninjaCooldown = CustomOption.Create(381, Types.Impostor, "忍者标记冷却", 30f, 10f, 120f, 5f, ninjaSpawnRate);
            ninjaKnowsTargetLocation = CustomOption.Create(382, Types.Impostor, "忍者可知目标位置", true, ninjaSpawnRate);
            ninjaTraceTime = CustomOption.Create(383, Types.Impostor, "追踪时长", 5f, 1f, 20f, 0.5f, ninjaSpawnRate);
            ninjaTraceColorTime = CustomOption.Create(384, Types.Impostor, "追踪颜色淡化前时长", 2f, 0f, 20f, 0.5f, ninjaSpawnRate);
			ninjaInvisibleDuration = CustomOption.Create(385, Types.Impostor, "忍者隐身时长", 3f, 0f, 20f, 1f, ninjaSpawnRate);


            guesserSpawnRate = CustomOption.Create(310,Types.Neutral, cs(Guesser.color, "赌怪生成概率"), rates, null, true);
            guesserIsImpGuesserRate = CustomOption.Create(311,Types.Neutral, "邪恶赌怪生成概率", rates, guesserSpawnRate);
            guesserNumberOfShots = CustomOption.Create(312,Types.Neutral, "赌怪可赌次数", 2f, 1f, 15f, 1f, guesserSpawnRate);
            guesserHasMultipleShotsPerMeeting = CustomOption.Create(313,Types.Neutral, "赌怪可在一轮会议中多次使用技能", false, guesserSpawnRate);
            guesserShowInfoInGhostChat = CustomOption.Create(314,Types.Neutral, "赌怪在幽灵视野中可见", true, guesserSpawnRate);
            guesserKillsThroughShield  = CustomOption.Create(315,Types.Neutral, "赌怪无视医生护盾", true, guesserSpawnRate);
            guesserEvilCanKillSpy  = CustomOption.Create(316,Types.Neutral, "邪恶赌怪可猜测间谍", true, guesserSpawnRate);
            guesserSpawnBothRate = CustomOption.Create(317,Types.Neutral, "两种赌怪同时生成概率", rates, guesserSpawnRate);
            guesserCantGuessSnitchIfTaksDone = CustomOption.Create(318,Types.Neutral, "告密者任务完成后不能被赌", true, guesserSpawnRate);

            jesterSpawnRate = CustomOption.Create(60,Types.Neutral, cs(Jester.color, "小丑生成概率"), rates, null, true);
            jesterCanCallEmergency = CustomOption.Create(61,Types.Neutral, "小丑能召开紧急会议", true, jesterSpawnRate);
            jesterHasImpostorVision = CustomOption.Create(62,Types.Neutral, "小丑拥有内鬼视野", false, jesterSpawnRate);

            arsonistSpawnRate = CustomOption.Create(290,Types.Neutral, cs(Arsonist.color, "纵火犯生成概率"), rates, null, true);
            arsonistCooldown = CustomOption.Create(291,Types.Neutral, "浇油冷却", 12.5f, 2.5f, 60f, 2.5f, arsonistSpawnRate);
            arsonistDuration = CustomOption.Create(292,Types.Neutral, "浇油花费时长", 3f, 1f, 10f, 1f, arsonistSpawnRate);

            jackalSpawnRate = CustomOption.Create(220,Types.Neutral, cs(Jackal.color, "豺狼生成概率"), rates, null, true);
            jackalKillCooldown = CustomOption.Create(221,Types.Neutral, "豺狼/走狗击杀冷却", 30f, 10f, 60f, 2.5f, jackalSpawnRate);
            jackalCreateSidekickCooldown = CustomOption.Create(222,Types.Neutral, "豺狼招募走狗冷却", 30f, 10f, 60f, 2.5f, jackalSpawnRate);
            jackalCanUseVents = CustomOption.Create(223,Types.Neutral, "豺狼可使用管道", true, jackalSpawnRate);
            jackalCanCreateSidekick = CustomOption.Create(224,Types.Neutral, "豺狼能招募走狗", false, jackalSpawnRate);
            sidekickPromotesToJackal = CustomOption.Create(225,Types.Neutral, "豺狼死后走狗晋升豺狼", false, jackalSpawnRate);
            sidekickCanKill = CustomOption.Create(226,Types.Neutral, "走狗可击杀", false, jackalSpawnRate);
            sidekickCanUseVents = CustomOption.Create(227,Types.Neutral, "走狗可使用管道", true, jackalSpawnRate);
            jackalPromotedFromSidekickCanCreateSidekick = CustomOption.Create(228,Types.Neutral, "走狗晋升豺狼后可招募新走狗", true, jackalSpawnRate);
            jackalCanCreateSidekickFromImpostor = CustomOption.Create(229,Types.Neutral, "豺狼可招募内鬼成为他的走狗", true, jackalSpawnRate);
            jackalAndSidekickHaveImpostorVision = CustomOption.Create(430,Types.Neutral, "豺狼和跟班拥有内鬼视野", false, jackalSpawnRate);

            vultureSpawnRate = CustomOption.Create(340,Types.Neutral, cs(Vulture.color, "秃鹫生成概率"), rates, null, true);
            vultureCooldown = CustomOption.Create(341,Types.Neutral, "秃鹫技能冷却", 15f, 10f, 60f, 2.5f, vultureSpawnRate);
            vultureNumberToWin = CustomOption.Create(342,Types.Neutral, "需要食用的尸体数量", 4f, 1f, 10f, 1f, vultureSpawnRate);
            vultureCanUseVents = CustomOption.Create(343,Types.Neutral, "秃鹫可使用管道", true, vultureSpawnRate);
            vultureShowArrows = CustomOption.Create(344,Types.Neutral, "显示箭头指向尸体", true, vultureSpawnRate);

            lawyerSpawnRate = CustomOption.Create(350,Types.Neutral, cs(Lawyer.color, "律师生成概率"), rates, null, true);
            lawyerTargetCanBeJester = CustomOption.Create(351,Types.Neutral, "律师的客户可以是小丑", true, lawyerSpawnRate);
            lawyerVision = CustomOption.Create(354,Types.Neutral, "律师视野", 1f, 0.25f, 3f, 0.25f, lawyerSpawnRate);
            lawyerKnowsRole = CustomOption.Create(355,Types.Neutral, "律师知道客户角色", false, lawyerSpawnRate);
            pursuerCooldown = CustomOption.Create(356,Types.Neutral, "起诉人空包弹冷却", 30f, 5f, 60f, 2.5f, lawyerSpawnRate);
            pursuerBlanksNumber = CustomOption.Create(357,Types.Neutral, "起诉人空包弹数量", 5f, 1f, 20f, 1f, lawyerSpawnRate);

            shifterSpawnRate = CustomOption.Create(70,Types.Crewmate, cs(Shifter.color, "交换师生成概率"), rates, null, true);
            shifterShiftsModifiers = CustomOption.Create(71,Types.Crewmate, "交换能力增强(可交换医生护盾和恋人)", false, shifterSpawnRate);

            mayorSpawnRate = CustomOption.Create(80,Types.Crewmate, cs(Mayor.color, "市长生成概率"), rates, null, true);
            mayorCanSeeVoteColors = CustomOption.Create(81,Types.Crewmate, "市长可见投票颜色", false, mayorSpawnRate);
            mayorTasksNeededToSeeVoteColors = CustomOption.Create(82, Types.Crewmate, "要可见投票颜色需要完成的任务数", 5f, 0f, 20f, 1f, mayorCanSeeVoteColors);
            mayorMeetingButton = CustomOption.Create(83, Types.Crewmate, "远程拍桌按钮", true, mayorSpawnRate);
            mayorMaxRemoteMeetings = CustomOption.Create(84, Types.Crewmate, "远程拍桌次数", 1f, 1f, 5f, 1f, mayorMeetingButton);
            
            engineerSpawnRate = CustomOption.Create(90,Types.Crewmate, cs(Engineer.color, "工程师生成概率"), rates, null, true);
            engineerNumberOfFixes = CustomOption.Create(91,Types.Crewmate, "工程师可维修破坏次数", 1f, 1f, 3f, 1f, engineerSpawnRate);
            engineerHighlightForImpostors = CustomOption.Create(92,Types.Crewmate, "内鬼能看见工程师在管道中", true, engineerSpawnRate);
            engineerHighlightForTeamJackal = CustomOption.Create(93,Types.Crewmate, "豺狼和走狗能看到工程师在管道中 ", true, engineerSpawnRate);

            soliderSpawnRate = CustomOption.Create(190,Types.Crewmate, cs(Solider.color, "士兵生成概率"), rates, null, true);
            bulletProofDisappearLatency = CustomOption.Create(191,Types.Crewmate,"防弹衣失效延迟",10.0f,5.0f,30.0f,5.0f,soliderSpawnRate);
            
            positionShifterSpawnRate = CustomOption.Create(910,Types.Crewmate, cs(PositionShifter.color, "换位者生成概率"), rates, null, true);
            positionShiftCooldown = CustomOption.Create(911,Types.Crewmate,"移形换位冷却时间",30.0f,0.0f,60.0f,5.0f,positionShifterSpawnRate);
            
            sheriffSpawnRate = CustomOption.Create(100,Types.Crewmate, cs(Sheriff.color, "警长生成概率"), rates, null, true);
            sheriffCooldown = CustomOption.Create(101,Types.Crewmate, "警长击杀冷却", 30f, 10f, 60f, 2.5f, sheriffSpawnRate);
            sheriffCanKillNeutrals = CustomOption.Create(102,Types.Crewmate, "警长可击杀中立职业", false, sheriffSpawnRate);
            deputySpawnRate = CustomOption.Create(103,Types.Crewmate, "警长拥有警员的概率", rates, sheriffSpawnRate);
            deputyNumberOfHandcuffs = CustomOption.Create(104,Types.Crewmate, "警员手铐数量", 3f, 1f, 10f, 1f, deputySpawnRate);
            deputyHandcuffCooldown = CustomOption.Create(105,Types.Crewmate, "手铐冷却", 30f, 10f, 60f, 2.5f, deputySpawnRate);
            deputyHandcuffDuration = CustomOption.Create(106,Types.Crewmate, "手铐持续时间", 15f, 5f, 60f, 2.5f, deputySpawnRate);
            deputyKnowsSheriff = CustomOption.Create(107,Types.Crewmate, "警长和警员互相可知身份 ", true, deputySpawnRate);
            deputyGetsPromoted = CustomOption.Create(108,Types.Crewmate, "警员在警长死后可升职为警长", new string[] { "关闭", "开启 (立即生效)", "开启 (会议后生效)" }, deputySpawnRate);
            deputyKeepsHandcuffs = CustomOption.Create(109,Types.Crewmate, "警员升职后保留手铐", true, deputyGetsPromoted);

            lighterSpawnRate = CustomOption.Create(110,Types.Crewmate, cs(Lighter.color, "秉烛者生成概率"), rates, null, true);
            lighterModeLightsOnVision = CustomOption.Create(111,Types.Crewmate, "未关灯时秉烛视野", 2f, 0.25f, 5f, 0.25f, lighterSpawnRate);
            lighterModeLightsOffVision = CustomOption.Create(112,Types.Crewmate, "关灯后秉烛视野", 0.75f, 0.25f, 5f, 0.25f, lighterSpawnRate);
            lighterCooldown = CustomOption.Create(113,Types.Crewmate, "秉烛冷却", 30f, 5f, 120f, 5f, lighterSpawnRate);
            lighterDuration = CustomOption.Create(114,Types.Crewmate, "秉烛持续时间", 5f, 2.5f, 60f, 2.5f, lighterSpawnRate);

            detectiveSpawnRate = CustomOption.Create(120,Types.Crewmate, cs(Detective.color, "侦探生成概率"), rates, null, true);
            detectiveAnonymousFootprints = CustomOption.Create(121,Types.Crewmate, "使用匿名脚印", false, detectiveSpawnRate); 
            detectiveFootprintIntervall = CustomOption.Create(122,Types.Crewmate, "脚印生成间隔时间", 0.5f, 0.25f, 10f, 0.25f, detectiveSpawnRate);
            detectiveFootprintDuration = CustomOption.Create(123,Types.Crewmate, "脚印残留时间", 5f, 0.25f, 10f, 0.25f, detectiveSpawnRate);
            detectiveReportNameDuration = CustomOption.Create(124,Types.Crewmate, "侦探多久报告尸体能显示凶手姓名", 0, 0, 60, 2.5f, detectiveSpawnRate);
            detectiveReportColorDuration = CustomOption.Create(125,Types.Crewmate, "侦探多久报告尸体能显示凶手颜色", 20, 0, 120, 2.5f, detectiveSpawnRate);

            timeMasterSpawnRate = CustomOption.Create(130,Types.Crewmate, cs(TimeMaster.color, "时间大师生成概率"), rates, null, true);
            timeMasterCooldown = CustomOption.Create(131,Types.Crewmate, "时间大师技能冷却", 30f, 10f, 120f, 2.5f, timeMasterSpawnRate);
            timeMasterRewindTime = CustomOption.Create(132,Types.Crewmate, "回溯时长", 3f, 1f, 10f, 1f, timeMasterSpawnRate);
            timeMasterShieldDuration = CustomOption.Create(133,Types.Crewmate, "时间护盾持续时长", 3f, 1f, 20f, 1f, timeMasterSpawnRate);

            medicSpawnRate = CustomOption.Create(140,Types.Crewmate, cs(Medic.color, "医生生成概率"), rates, null, true);
            medicShowShielded = CustomOption.Create(143,Types.Crewmate, "医生护盾可见对象", new string[] {"所有人", "护盾目标 + 医生", "医生"}, medicSpawnRate);
            medicShowAttemptToShielded = CustomOption.Create(144,Types.Crewmate, "被护盾的目标能看见击杀尝试", false, medicSpawnRate);
            medicSetOrShowShieldAfterMeeting  = CustomOption.Create(145,Types.Crewmate, "护盾会议后生效", false, medicSpawnRate);
            medicShowAttemptToMedic = CustomOption.Create(146,Types.Crewmate, "医生可以看见对护盾目标的击杀尝试", false, medicSpawnRate);

            swapperSpawnRate = CustomOption.Create(150,Types.Crewmate, cs(Swapper.color, "换票师生成概率"), rates, null, true);
            swapperCanCallEmergency = CustomOption.Create(151,Types.Crewmate, "换票师能召开紧急会议", false, swapperSpawnRate);
            swapperCanOnlySwapOthers = CustomOption.Create(152,Types.Crewmate, "换票师只可交换他人的得票", false, swapperSpawnRate);
            swapperSwapsNumber = CustomOption.Create(153, Types.Crewmate, "初始换票次数", 1f, 0f, 5f, 1f, swapperSpawnRate);
            swapperRechargeTasksNumber = CustomOption.Create(154, Types.Crewmate, "完成多少任务可充能一次换票次数", 2f, 1f, 10f, 1f, swapperSpawnRate);

            seerSpawnRate = CustomOption.Create(160,Types.Crewmate, cs(Seer.color, "先知生成概率"), rates, null, true);
            seerMode = CustomOption.Create(161,Types.Crewmate, "先知模式", new string[]{ "显示死亡闪光 + 灵魂", "显示死亡闪光", "显示灵魂"}, seerSpawnRate);
            seerLimitSoulDuration = CustomOption.Create(163,Types.Crewmate, "限制先知的可见灵魂时长", false, seerSpawnRate);
            seerSoulDuration = CustomOption.Create(162,Types.Crewmate, "先知可见灵魂时长", 15f, 0f, 120f, 5f, seerLimitSoulDuration);
        
            hackerSpawnRate = CustomOption.Create(170,Types.Crewmate, cs(Hacker.color, "骇客生成概率"), rates, null, true);
            hackerCooldown = CustomOption.Create(171,Types.Crewmate, "骇入技能冷却", 30f, 5f, 60f, 5f, hackerSpawnRate);
            hackerHackeringDuration = CustomOption.Create(172,Types.Crewmate, "骇入持续时长", 10f, 2.5f, 60f, 2.5f, hackerSpawnRate);
            hackerOnlyColorType = CustomOption.Create(173,Types.Crewmate, "骇入之可见颜色深浅", false, hackerSpawnRate);
            hackerToolsNumber = CustomOption.Create(174,Types.Crewmate, "最大移动装置充能次数", 5f, 1f, 30f, 1f, hackerSpawnRate);
            hackerRechargeTasksNumber = CustomOption.Create(175,Types.Crewmate, "移动装置充能所需任务数", 2f, 1f, 5f, 1f, hackerSpawnRate);
            hackerNoMove = CustomOption.Create(176,Types.Crewmate, "使用移动装置时无法移动", true, hackerSpawnRate);

            trackerSpawnRate = CustomOption.Create(200,Types.Crewmate, cs(Tracker.color, "追踪者生成概率"), rates, null, true);
            trackerUpdateIntervall = CustomOption.Create(201,Types.Crewmate, "追踪箭头更新间隔", 5f, 1f, 30f, 1f, trackerSpawnRate);
            trackerResetTargetAfterMeeting = CustomOption.Create(202,Types.Crewmate, "追踪者会议后可重选追踪目标", false, trackerSpawnRate);
            trackerCanTrackCorpses = CustomOption.Create(203,Types.Crewmate, "追踪者可追踪尸体", true, trackerSpawnRate);
            trackerCorpsesTrackingCooldown = CustomOption.Create(204,Types.Crewmate, "追踪尸体冷却", 30f, 5f, 120f, 5f, trackerCanTrackCorpses);
            trackerCorpsesTrackingDuration = CustomOption.Create(205,Types.Crewmate, "追踪尸体持续时长", 5f, 2.5f, 30f, 2.5f, trackerCanTrackCorpses);
                           
            snitchSpawnRate = CustomOption.Create(210,Types.Crewmate, cs(Snitch.color, "告密者生成概率"), rates, null, true);
            snitchLeftTasksForReveal = CustomOption.Create(211,Types.Crewmate, "告密者还剩多少任务时会暴露", 1f, 0f, 5f, 1f, snitchSpawnRate);
            snitchIncludeTeamJackal = CustomOption.Create(212,Types.Crewmate, "是否可追踪豺狼阵营", false, snitchSpawnRate);
            snitchTeamJackalUseDifferentArrowColor = CustomOption.Create(213,Types.Crewmate, "使用不同颜色的箭头来表示豺狼阵营", true, snitchIncludeTeamJackal);

            spySpawnRate = CustomOption.Create(240,Types.Crewmate, cs(Spy.color, "间谍生成概率"), rates, null, true);
            spyCanDieToSheriff = CustomOption.Create(241,Types.Crewmate, "间谍可被警长杀死", false, spySpawnRate);
            spyImpostorsCanKillAnyone = CustomOption.Create(242,Types.Crewmate, "如果有间谍存在，内鬼可杀死任何人", true, spySpawnRate);
            spyCanEnterVents = CustomOption.Create(243,Types.Crewmate, "间谍可以跳入管道", false, spySpawnRate);
            spyHasImpostorVision = CustomOption.Create(244,Types.Crewmate, "间谍拥有内鬼视野", false, spySpawnRate);

            portalmakerSpawnRate = CustomOption.Create(390, Types.Crewmate, cs(Portalmaker.color, "传送门制造者生成概率"), rates, null, true);
            portalmakerCooldown = CustomOption.Create(391, Types.Crewmate, "制造传送门冷却", 30f, 10f, 60f, 2.5f, portalmakerSpawnRate);
            portalmakerUsePortalCooldown = CustomOption.Create(392, Types.Crewmate, "使用传送门冷却", 30f, 10f, 60f, 2.5f, portalmakerSpawnRate);
            portalmakerLogOnlyColorType = CustomOption.Create(393, Types.Crewmate, "传送记录只显示颜色深浅", true, portalmakerSpawnRate);
            portalmakerLogHasTime = CustomOption.Create(394, Types.Crewmate, "传送记录有时间信息", true, portalmakerSpawnRate);
            
            securityGuardSpawnRate = CustomOption.Create(280,Types.Crewmate, cs(SecurityGuard.color, "保安生成概率"), rates, null, true);
            securityGuardCooldown = CustomOption.Create(281,Types.Crewmate, "保安技能冷却", 30f, 10f, 60f, 2.5f, securityGuardSpawnRate);
            securityGuardTotalScrews = CustomOption.Create(282,Types.Crewmate, "保安拥有螺丝钉数", 7f, 1f, 15f, 1f, securityGuardSpawnRate);
            securityGuardCamPrice = CustomOption.Create(283,Types.Crewmate, "安放摄像头消耗的螺丝钉数量", 2f, 1f, 15f, 1f, securityGuardSpawnRate);
            securityGuardVentPrice = CustomOption.Create(284,Types.Crewmate, "封闭管道消耗的螺丝钉数量", 1f, 1f, 15f, 1f, securityGuardSpawnRate);
            securityGuardCamDuration = CustomOption.Create(285,Types.Crewmate, "保安使用技能持续时间", 10f, 2.5f, 60f, 2.5f, securityGuardSpawnRate);
            securityGuardCamMaxCharges = CustomOption.Create(286,Types.Crewmate, "螺丝钉最大补充数量", 5f, 1f, 30f, 1f, securityGuardSpawnRate);
            securityGuardCamRechargeTasksNumber = CustomOption.Create(287,Types.Crewmate, "补充螺丝钉需要做多少任务", 3f, 1f, 10f, 1f, securityGuardSpawnRate);
            securityGuardNoMove = CustomOption.Create(288,Types.Crewmate, "保安安放摄像头时的停留时间", true, securityGuardSpawnRate);
            
            mediumSpawnRate = CustomOption.Create(360,Types.Crewmate, cs(Medium.color, "通灵师生成概率"), rates, null, true);
            mediumCooldown = CustomOption.Create(361,Types.Crewmate, "通灵师提问冷却", 30f, 5f, 120f, 5f, mediumSpawnRate);
            mediumDuration = CustomOption.Create(362,Types.Crewmate, "通灵师提问持续时间", 3f, 0f, 15f, 1f, mediumSpawnRate);
            mediumOneTimeUse = CustomOption.Create(363,Types.Crewmate, "每个灵魂只可被提问一次", false, mediumSpawnRate);
            
            // Modifier
            modifierBloody = CustomOption.Create(1000, Types.Modifier, cs(Color.yellow, "血淋淋的生成概率"), rates, null, true);
            modifierBloodyQuantity = CustomOption.Create(1001, Types.Modifier, cs(Color.yellow, "血淋淋的数量"), ratesModifier, modifierBloody);
            modifierBloodyDuration = CustomOption.Create(1002, Types.Modifier, "血迹持续时长", 10f, 3f, 60f, 1f, modifierBloody);

            modifierAntiTeleport = CustomOption.Create(1010, Types.Modifier, cs(Color.yellow, "停滞的生成概率"), rates, null, true);
            modifierAntiTeleportQuantity = CustomOption.Create(1011, Types.Modifier, cs(Color.yellow, "停滞的数量"), ratesModifier, modifierAntiTeleport);

            modifierTieBreaker = CustomOption.Create(1020, Types.Modifier, cs(Color.yellow, "裁决的生成概率"), rates, null, true);

            vigilanteSpawnRate = CustomOption.Create(900,Types.Neutral,cs(Vigilante.color,"义警与线人生成概率"),rates,null,true);
            vigilanteCooldown = CustomOption.Create(901,Types.Neutral, "义警击杀冷却", 30f, 10f, 60f, 2.5f, vigilanteSpawnRate);
            
            modifierBait = CustomOption.Create(1030, Types.Modifier, cs(Color.yellow, "诱饵的生成概率"), rates, null, true);
            modifierBaitQuantity = CustomOption.Create(1031, Types.Modifier, cs(Color.yellow, "诱饵的数量"), ratesModifier, modifierBait);
            modifierBaitReportDelayMin = CustomOption.Create(1032, Types.Modifier, "诱饵的延迟报告最低时长", 0f, 0f, 10f, 1f, modifierBait);
            modifierBaitReportDelayMax = CustomOption.Create(1033, Types.Modifier, "诱饵的延迟报告最大时长", 0f, 0f, 10f, 1f, modifierBait);
            modifierBaitShowKillFlash = CustomOption.Create(1034, Types.Modifier, "是否用闪光警告杀人者", true, modifierBait);

            modifierLover = CustomOption.Create(1040, Types.Modifier, cs(Color.yellow, "热恋的生成概率"), rates, null, true);
            modifierLoverImpLoverRate = CustomOption.Create(1041, Types.Modifier, "有一个恋人是内鬼的概率", rates, modifierLover);
            modifierLoverBothDie = CustomOption.Create(1042, Types.Modifier, "恋人共死", true, modifierLover);
            modifierLoverEnableChat = CustomOption.Create(1043, Types.Modifier, "允许恋人私聊", true, modifierLover);

            modifierSunglasses = CustomOption.Create(1050, Types.Modifier, cs(Color.yellow, "目盲的生成概率"), rates, null, true);
            modifierSunglassesQuantity = CustomOption.Create(1051, Types.Modifier, cs(Color.yellow, "目盲的数量"), ratesModifier, modifierSunglasses);
            modifierSunglassesVision = CustomOption.Create(1052, Types.Modifier, "目盲的视野范围", new string[] { "-10%", "-20%", "-30%", "-40%", "-50%" }, modifierSunglasses);

            modifierMini = CustomOption.Create(1061, Types.Modifier, cs(Color.yellow, "迷你的生成概率"), rates, null, true);
            modifierMiniGrowingUpDuration = CustomOption.Create(1062, Types.Modifier, "迷你的长大时间", 400f, 100f, 1500f, 100f, modifierMini);

            modifierVip = CustomOption.Create(1070, Types.Modifier, cs(Color.yellow, "尊贵的生成概率"), rates, null, true);
            modifierVipQuantity = CustomOption.Create(1071, Types.Modifier, cs(Color.yellow, "尊贵的数量"), ratesModifier, modifierVip);
            modifierVipShowColor = CustomOption.Create(1072, Types.Modifier, "显示尊贵的队伍颜色", true, modifierVip);

            modifierInvert = CustomOption.Create(1080, Types.Modifier, cs(Color.yellow, "颠倒的生成概率"), rates, null, true);
            modifierInvertQuantity = CustomOption.Create(1081, Types.Modifier, cs(Color.yellow, "颠倒的数量"), ratesModifier, modifierInvert);
            modifierInvertDuration = CustomOption.Create(1082, Types.Modifier, "颠倒的持续几轮会议", 3f, 1f, 15f, 1f, modifierInvert);

            // Other options

            maxNumberOfMeetings = CustomOption.Create(3,Types.General, "会议总数（市长会议除外）", 10, 0, 15, 1, null, true);
            blockSkippingInEmergencyMeetings = CustomOption.Create(4,Types.General, "紧急会议中禁止跳过", false);
            noVoteIsSelfVote = CustomOption.Create(5,Types.General, "不能给自己投票", false, blockSkippingInEmergencyMeetings);
            hidePlayerNames = CustomOption.Create(6,Types.General, "隐藏玩家姓名", false);
            allowParallelMedBayScans = CustomOption.Create(7,Types.General, "允许同时进行扫描任务", false);
            shieldFirstKill = CustomOption.Create(8, Types.General, "上轮首刀保护", false);

            dynamicMap = CustomOption.Create(500,Types.General, "随机地图启用", false, null, false);
            dynamicMapEnableSkeld = CustomOption.Create(501,Types.General, "Skeld加入随机列表", true, dynamicMap, false);
            dynamicMapEnableMira = CustomOption.Create(502,Types.General, "Mira加入随机列表", true, dynamicMap, false);
            dynamicMapEnablePolus = CustomOption.Create(503,Types.General, "Polus加入随机列表", true, dynamicMap, false);
            dynamicMapEnableAirShip = CustomOption.Create(504,Types.General, "Airship加入随机列表", true, dynamicMap, false);
            
            dynamicMapEnableSubmerged = CustomOption.Create(505, Types.General, "Submerged加入随即列表", true, dynamicMap, false);

            blockedRolePairings.Add((byte)RoleId.Vampire, new [] { (byte)RoleId.Warlock});
            blockedRolePairings.Add((byte)RoleId.Warlock, new [] { (byte)RoleId.Vampire});
            blockedRolePairings.Add((byte)RoleId.Spy, new [] { (byte)RoleId.Mini});
            blockedRolePairings.Add((byte)RoleId.Mini, new [] { (byte)RoleId.Spy});
            blockedRolePairings.Add((byte)RoleId.Vulture, new [] { (byte)RoleId.Cleaner});
            blockedRolePairings.Add((byte)RoleId.Cleaner, new [] { (byte)RoleId.Vulture});
            
        }
    }
}
