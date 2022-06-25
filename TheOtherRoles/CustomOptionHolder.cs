using System.Collections.Generic;
using UnityEngine;
using static TheOtherRoles.TheOtherRoles;
using Types = TheOtherRoles.CustomOption.CustomOptionType;

namespace TheOtherRoles {
    public class CustomOptionHolder {
        public static string[] rates = new string[]{"0%", "10%", "20%", "30%", "40%", "50%", "60%", "70%", "80%", "90%", "100%"};
        public static string[] ratesModifier = new string[]{"1", "2", "3"};
        public static string[] presets = new string[]{"Ԥ�� 1", "Ԥ�� 2", "Ԥ�� 3", "Ԥ�� 4", "Ԥ�� 5"};
        
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
            
            presetSelection = CustomOption.Create(0,Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "Ԥ��"), presets, null, true);
            activateRoles = CustomOption.Create(1,Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "����ģ�鲢����ԭ���ɫ"), true, null, true);

            // Using new id's for the options to not break compatibilty with older versions

            crewmateRolesCountMin = CustomOption.Create(300,Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "��С��Ա����"), 0f, 0f, 15f, 1f, null, true);
            crewmateRolesCountMax = CustomOption.Create(301,Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "���Ա����"), 0f, 0f, 15f, 1f);
            neutralRolesCountMin = CustomOption.Create(302,Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "��С��������"), 0f, 0f, 15f, 1f);
            neutralRolesCountMax = CustomOption.Create(303,Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "�����������"), 0f, 0f, 15f, 1f);
            impostorRolesCountMin = CustomOption.Create(304,Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "��С�ڹ�����"), 0f, 0f, 3f, 1f);
            impostorRolesCountMax = CustomOption.Create(305,Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "����ڹ�����"), 0f, 0f, 3f, 1f);
            modifiersCountMin = CustomOption.Create(306, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "��С�����ɫ����"), 0f, 0f, 15f, 1f);
            modifiersCountMax = CustomOption.Create(307, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "�������ɫ����"), 0f, 0f, 15f, 1f);

            mafiaSpawnRate = CustomOption.Create(10,Types.Impostor, cs(Janitor.color, "���ֵ����ɸ���"), rates, null, true);
            janitorCooldown = CustomOption.Create(11,Types.Impostor, "��๤��ȴ", 30f, 10f, 60f, 2.5f, mafiaSpawnRate);

            morphlingSpawnRate = CustomOption.Create(20,Types.Impostor, cs(Morphling.color, "���������ɸ���"), rates, null, true);
            morphlingCooldown = CustomOption.Create(21,Types.Impostor, "���μ�����ȴ", 30f, 10f, 60f, 2.5f, morphlingSpawnRate);
            morphlingDuration = CustomOption.Create(22,Types.Impostor, "���γ���ʱ��", 10f, 1f, 20f, 0.5f, morphlingSpawnRate);

            camouflagerSpawnRate = CustomOption.Create(30,Types.Impostor, cs(Camouflager.color, "αװ�����ɸ���"), rates, null, true);
            camouflagerCooldown = CustomOption.Create(31,Types.Impostor, "αװ������ȴ", 30f, 10f, 60f, 2.5f, camouflagerSpawnRate);
            camouflagerDuration = CustomOption.Create(32,Types.Impostor, "αװ����ʱ��", 10f, 1f, 20f, 0.5f, camouflagerSpawnRate);

            vampireSpawnRate = CustomOption.Create(40,Types.Impostor, cs(Vampire.color, "��Ѫ�����ɸ���"), rates, null, true);
            vampireKillDelay = CustomOption.Create(41,Types.Impostor, "��Ѫ��ɱ���ӳ�", 10f, 1f, 20f, 1f, vampireSpawnRate);
            vampireCooldown = CustomOption.Create(42,Types.Impostor, "��Ѫ��ҧ����ȴ", 30f, 10f, 60f, 2.5f, vampireSpawnRate);
            vampireCanKillNearGarlics = CustomOption.Create(43,Types.Impostor, "��Ѫ������ڴ��⸽����ɱ", true, vampireSpawnRate);

            eraserSpawnRate = CustomOption.Create(230,Types.Impostor, cs(Eraser.color, "Ĩ�������ɸ���"), rates, null, true);
            eraserCooldown = CustomOption.Create(231,Types.Impostor, "Ĩ��������ȴ", 30f, 10f, 120f, 5f, eraserSpawnRate);
            eraserCanEraseAnyone = CustomOption.Create(232,Types.Impostor, "Ĩ���߿�Ĩ���κν�ɫ", false, eraserSpawnRate);

            tricksterSpawnRate = CustomOption.Create(250,Types.Impostor, cs(Trickster.color, "����ʦ���ɸ���"), rates, null, true);
            tricksterPlaceBoxCooldown = CustomOption.Create(251,Types.Impostor, "��ƺ���ȴ", 10f, 2.5f, 30f, 2.5f, tricksterSpawnRate);
            tricksterLightsOutCooldown = CustomOption.Create(252,Types.Impostor, "����ʦ�ص���ȴʱ��", 30f, 10f, 60f, 5f, tricksterSpawnRate);
            tricksterLightsOutDuration = CustomOption.Create(253,Types.Impostor, "����ʦ�صƳ���ʱ��", 15f, 5f, 60f, 2.5f, tricksterSpawnRate);

            cleanerSpawnRate = CustomOption.Create(260,Types.Impostor, cs(Cleaner.color, "���������ɸ���"), rates, null, true);
            cleanerCooldown = CustomOption.Create(261,Types.Impostor, "��������ȴ", 30f, 10f, 60f, 2.5f, cleanerSpawnRate);

            warlockSpawnRate = CustomOption.Create(270,Types.Impostor, cs(Cleaner.color, "��ʿ���ɸ���"), rates, null, true);
            warlockCooldown = CustomOption.Create(271,Types.Impostor, "����������ȴ", 30f, 10f, 60f, 2.5f, warlockSpawnRate);
            warlockRootTime = CustomOption.Create(272,Types.Impostor, "��������ʱ��", 5f, 0f, 15f, 1f, warlockSpawnRate);

            bountyHunterSpawnRate = CustomOption.Create(320,Types.Impostor, cs(BountyHunter.color, "�ͽ��������ɸ���"), rates, null, true);
            bountyHunterBountyDuration = CustomOption.Create(321,Types.Impostor, "�ͽ�Ŀ��ı���ʱ��",  60f, 10f, 180f, 10f, bountyHunterSpawnRate);
            bountyHunterReducedCooldown = CustomOption.Create(322,Types.Impostor, "ɱ���ͽ�Ŀ���Ļ�ɱ��ȴʱ��", 2.5f, 0f, 30f, 2.5f, bountyHunterSpawnRate);
            bountyHunterPunishmentTime = CustomOption.Create(323,Types.Impostor, "��ɱ���ͽ�Ŀ���Ķ�����ȴʱ��", 20f, 0f, 60f, 2.5f, bountyHunterSpawnRate);
            bountyHunterShowArrow = CustomOption.Create(324,Types.Impostor, "��ʾָ���ͽ�Ŀ��ļ�ͷ", true, bountyHunterSpawnRate);
            bountyHunterArrowUpdateIntervall = CustomOption.Create(325,Types.Impostor, "��ͷ���¼��", 15f, 2.5f, 60f, 2.5f, bountyHunterShowArrow);

            witchSpawnRate = CustomOption.Create(370,Types.Impostor, cs(Witch.color, "Ů�����ɸ���"), rates, null, true);
            witchCooldown = CustomOption.Create(371,Types.Impostor, "Ů��ʩ����ȴ", 30f, 10f, 120f, 5f, witchSpawnRate);
            witchAdditionalCooldown = CustomOption.Create(372,Types.Impostor, "Ů�׶�����ȴ", 10f, 0f, 60f, 5f, witchSpawnRate);
            witchCanSpellAnyone = CustomOption.Create(373,Types.Impostor, "Ů�׿ɶ��κ���ʩ��", false, witchSpawnRate);
            witchSpellCastingDuration = CustomOption.Create(374,Types.Impostor, "ʩ�����ʱ��", 1f, 0f, 10f, 1f, witchSpawnRate);
            witchTriggerBothCooldowns = CustomOption.Create(375,Types.Impostor, "ʩ�����ɱ������ȴ", true, witchSpawnRate);
            witchVoteSavesTargets = CustomOption.Create(376,Types.Impostor, "��Ů��Ͷ�������ȱ�ʩ����", true, witchSpawnRate);


            ninjaSpawnRate = CustomOption.Create(380, Types.Impostor, cs(Ninja.color, "�������ɸ���"), rates, null, true);
            ninjaCooldown = CustomOption.Create(381, Types.Impostor, "���߱����ȴ", 30f, 10f, 120f, 5f, ninjaSpawnRate);
            ninjaKnowsTargetLocation = CustomOption.Create(382, Types.Impostor, "���߿�֪Ŀ��λ��", true, ninjaSpawnRate);
            ninjaTraceTime = CustomOption.Create(383, Types.Impostor, "׷��ʱ��", 5f, 1f, 20f, 0.5f, ninjaSpawnRate);
            ninjaTraceColorTime = CustomOption.Create(384, Types.Impostor, "׷����ɫ����ǰʱ��", 2f, 0f, 20f, 0.5f, ninjaSpawnRate);
			ninjaInvisibleDuration = CustomOption.Create(385, Types.Impostor, "��������ʱ��", 3f, 0f, 20f, 1f, ninjaSpawnRate);


            guesserSpawnRate = CustomOption.Create(310,Types.Neutral, cs(Guesser.color, "�Ĺ����ɸ���"), rates, null, true);
            guesserIsImpGuesserRate = CustomOption.Create(311,Types.Neutral, "а��Ĺ����ɸ���", rates, guesserSpawnRate);
            guesserNumberOfShots = CustomOption.Create(312,Types.Neutral, "�ĹֿɶĴ���", 2f, 1f, 15f, 1f, guesserSpawnRate);
            guesserHasMultipleShotsPerMeeting = CustomOption.Create(313,Types.Neutral, "�Ĺֿ���һ�ֻ����ж��ʹ�ü���", false, guesserSpawnRate);
            guesserShowInfoInGhostChat = CustomOption.Create(314,Types.Neutral, "�Ĺ���������Ұ�пɼ�", true, guesserSpawnRate);
            guesserKillsThroughShield  = CustomOption.Create(315,Types.Neutral, "�Ĺ�����ҽ������", true, guesserSpawnRate);
            guesserEvilCanKillSpy  = CustomOption.Create(316,Types.Neutral, "а��Ĺֿɲ²���", true, guesserSpawnRate);
            guesserSpawnBothRate = CustomOption.Create(317,Types.Neutral, "���ֶĹ�ͬʱ���ɸ���", rates, guesserSpawnRate);
            guesserCantGuessSnitchIfTaksDone = CustomOption.Create(318,Types.Neutral, "������������ɺ��ܱ���", true, guesserSpawnRate);

            jesterSpawnRate = CustomOption.Create(60,Types.Neutral, cs(Jester.color, "С�����ɸ���"), rates, null, true);
            jesterCanCallEmergency = CustomOption.Create(61,Types.Neutral, "С�����ٿ���������", true, jesterSpawnRate);
            jesterHasImpostorVision = CustomOption.Create(62,Types.Neutral, "С��ӵ���ڹ���Ұ", false, jesterSpawnRate);

            arsonistSpawnRate = CustomOption.Create(290,Types.Neutral, cs(Arsonist.color, "�ݻ����ɸ���"), rates, null, true);
            arsonistCooldown = CustomOption.Create(291,Types.Neutral, "������ȴ", 12.5f, 2.5f, 60f, 2.5f, arsonistSpawnRate);
            arsonistDuration = CustomOption.Create(292,Types.Neutral, "���ͻ���ʱ��", 3f, 1f, 10f, 1f, arsonistSpawnRate);

            jackalSpawnRate = CustomOption.Create(220,Types.Neutral, cs(Jackal.color, "�������ɸ���"), rates, null, true);
            jackalKillCooldown = CustomOption.Create(221,Types.Neutral, "����/�߹���ɱ��ȴ", 30f, 10f, 60f, 2.5f, jackalSpawnRate);
            jackalCreateSidekickCooldown = CustomOption.Create(222,Types.Neutral, "������ļ�߹���ȴ", 30f, 10f, 60f, 2.5f, jackalSpawnRate);
            jackalCanUseVents = CustomOption.Create(223,Types.Neutral, "���ǿ�ʹ�ùܵ�", true, jackalSpawnRate);
            jackalCanCreateSidekick = CustomOption.Create(224,Types.Neutral, "��������ļ�߹�", false, jackalSpawnRate);
            sidekickPromotesToJackal = CustomOption.Create(225,Types.Neutral, "���������߹���������", false, jackalSpawnRate);
            sidekickCanKill = CustomOption.Create(226,Types.Neutral, "�߹��ɻ�ɱ", false, jackalSpawnRate);
            sidekickCanUseVents = CustomOption.Create(227,Types.Neutral, "�߹���ʹ�ùܵ�", true, jackalSpawnRate);
            jackalPromotedFromSidekickCanCreateSidekick = CustomOption.Create(228,Types.Neutral, "�߹��������Ǻ����ļ���߹�", true, jackalSpawnRate);
            jackalCanCreateSidekickFromImpostor = CustomOption.Create(229,Types.Neutral, "���ǿ���ļ�ڹ��Ϊ�����߹�", true, jackalSpawnRate);
            jackalAndSidekickHaveImpostorVision = CustomOption.Create(430,Types.Neutral, "���Ǻ͸���ӵ���ڹ���Ұ", false, jackalSpawnRate);

            vultureSpawnRate = CustomOption.Create(340,Types.Neutral, cs(Vulture.color, "ͺ�����ɸ���"), rates, null, true);
            vultureCooldown = CustomOption.Create(341,Types.Neutral, "ͺ�ռ�����ȴ", 15f, 10f, 60f, 2.5f, vultureSpawnRate);
            vultureNumberToWin = CustomOption.Create(342,Types.Neutral, "��Ҫʳ�õ�ʬ������", 4f, 1f, 10f, 1f, vultureSpawnRate);
            vultureCanUseVents = CustomOption.Create(343,Types.Neutral, "ͺ�տ�ʹ�ùܵ�", true, vultureSpawnRate);
            vultureShowArrows = CustomOption.Create(344,Types.Neutral, "��ʾ��ͷָ��ʬ��", true, vultureSpawnRate);

            lawyerSpawnRate = CustomOption.Create(350,Types.Neutral, cs(Lawyer.color, "��ʦ���ɸ���"), rates, null, true);
            lawyerTargetCanBeJester = CustomOption.Create(351,Types.Neutral, "��ʦ�Ŀͻ�������С��", true, lawyerSpawnRate);
            lawyerVision = CustomOption.Create(354,Types.Neutral, "��ʦ��Ұ", 1f, 0.25f, 3f, 0.25f, lawyerSpawnRate);
            lawyerKnowsRole = CustomOption.Create(355,Types.Neutral, "��ʦ֪���ͻ���ɫ", false, lawyerSpawnRate);
            pursuerCooldown = CustomOption.Create(356,Types.Neutral, "�����˿հ�����ȴ", 30f, 5f, 60f, 2.5f, lawyerSpawnRate);
            pursuerBlanksNumber = CustomOption.Create(357,Types.Neutral, "�����˿հ�������", 5f, 1f, 20f, 1f, lawyerSpawnRate);

            shifterSpawnRate = CustomOption.Create(70,Types.Crewmate, cs(Shifter.color, "����ʦ���ɸ���"), rates, null, true);
            shifterShiftsModifiers = CustomOption.Create(71,Types.Crewmate, "����������ǿ(�ɽ���ҽ�����ܺ�����)", false, shifterSpawnRate);

            mayorSpawnRate = CustomOption.Create(80,Types.Crewmate, cs(Mayor.color, "�г����ɸ���"), rates, null, true);
            mayorCanSeeVoteColors = CustomOption.Create(81,Types.Crewmate, "�г��ɼ�ͶƱ��ɫ", false, mayorSpawnRate);
            mayorTasksNeededToSeeVoteColors = CustomOption.Create(82, Types.Crewmate, "Ҫ�ɼ�ͶƱ��ɫ��Ҫ��ɵ�������", 5f, 0f, 20f, 1f, mayorCanSeeVoteColors);
            mayorMeetingButton = CustomOption.Create(83, Types.Crewmate, "Զ��������ť", true, mayorSpawnRate);
            mayorMaxRemoteMeetings = CustomOption.Create(84, Types.Crewmate, "Զ����������", 1f, 1f, 5f, 1f, mayorMeetingButton);
            
            engineerSpawnRate = CustomOption.Create(90,Types.Crewmate, cs(Engineer.color, "����ʦ���ɸ���"), rates, null, true);
            engineerNumberOfFixes = CustomOption.Create(91,Types.Crewmate, "����ʦ��ά���ƻ�����", 1f, 1f, 3f, 1f, engineerSpawnRate);
            engineerHighlightForImpostors = CustomOption.Create(92,Types.Crewmate, "�ڹ��ܿ�������ʦ�ڹܵ���", true, engineerSpawnRate);
            engineerHighlightForTeamJackal = CustomOption.Create(93,Types.Crewmate, "���Ǻ��߹��ܿ�������ʦ�ڹܵ��� ", true, engineerSpawnRate);

            soliderSpawnRate = CustomOption.Create(190,Types.Crewmate, cs(Solider.color, "ʿ�����ɸ���"), rates, null, true);
            bulletProofDisappearLatency = CustomOption.Create(191,Types.Crewmate,"������ʧЧ�ӳ�",10.0f,5.0f,30.0f,5.0f,soliderSpawnRate);
            
            positionShifterSpawnRate = CustomOption.Create(910,Types.Crewmate, cs(PositionShifter.color, "��λ�����ɸ���"), rates, null, true);
            positionShiftCooldown = CustomOption.Create(911,Types.Crewmate,"���λ�λ��ȴʱ��",30.0f,0.0f,60.0f,5.0f,positionShifterSpawnRate);
            
            sheriffSpawnRate = CustomOption.Create(100,Types.Crewmate, cs(Sheriff.color, "�������ɸ���"), rates, null, true);
            sheriffCooldown = CustomOption.Create(101,Types.Crewmate, "������ɱ��ȴ", 30f, 10f, 60f, 2.5f, sheriffSpawnRate);
            sheriffCanKillNeutrals = CustomOption.Create(102,Types.Crewmate, "�����ɻ�ɱ����ְҵ", false, sheriffSpawnRate);
            deputySpawnRate = CustomOption.Create(103,Types.Crewmate, "����ӵ�о�Ա�ĸ���", rates, sheriffSpawnRate);
            deputyNumberOfHandcuffs = CustomOption.Create(104,Types.Crewmate, "��Ա��������", 3f, 1f, 10f, 1f, deputySpawnRate);
            deputyHandcuffCooldown = CustomOption.Create(105,Types.Crewmate, "������ȴ", 30f, 10f, 60f, 2.5f, deputySpawnRate);
            deputyHandcuffDuration = CustomOption.Create(106,Types.Crewmate, "�������ʱ��", 15f, 5f, 60f, 2.5f, deputySpawnRate);
            deputyKnowsSheriff = CustomOption.Create(107,Types.Crewmate, "�����;�Ա�����֪��� ", true, deputySpawnRate);
            deputyGetsPromoted = CustomOption.Create(108,Types.Crewmate, "��Ա�ھ����������ְΪ����", new string[] { "�ر�", "���� (������Ч)", "���� (�������Ч)" }, deputySpawnRate);
            deputyKeepsHandcuffs = CustomOption.Create(109,Types.Crewmate, "��Ա��ְ��������", true, deputyGetsPromoted);

            lighterSpawnRate = CustomOption.Create(110,Types.Crewmate, cs(Lighter.color, "���������ɸ���"), rates, null, true);
            lighterModeLightsOnVision = CustomOption.Create(111,Types.Crewmate, "δ�ص�ʱ������Ұ", 2f, 0.25f, 5f, 0.25f, lighterSpawnRate);
            lighterModeLightsOffVision = CustomOption.Create(112,Types.Crewmate, "�صƺ������Ұ", 0.75f, 0.25f, 5f, 0.25f, lighterSpawnRate);
            lighterCooldown = CustomOption.Create(113,Types.Crewmate, "������ȴ", 30f, 5f, 120f, 5f, lighterSpawnRate);
            lighterDuration = CustomOption.Create(114,Types.Crewmate, "�������ʱ��", 5f, 2.5f, 60f, 2.5f, lighterSpawnRate);

            detectiveSpawnRate = CustomOption.Create(120,Types.Crewmate, cs(Detective.color, "��̽���ɸ���"), rates, null, true);
            detectiveAnonymousFootprints = CustomOption.Create(121,Types.Crewmate, "ʹ��������ӡ", false, detectiveSpawnRate); 
            detectiveFootprintIntervall = CustomOption.Create(122,Types.Crewmate, "��ӡ���ɼ��ʱ��", 0.5f, 0.25f, 10f, 0.25f, detectiveSpawnRate);
            detectiveFootprintDuration = CustomOption.Create(123,Types.Crewmate, "��ӡ����ʱ��", 5f, 0.25f, 10f, 0.25f, detectiveSpawnRate);
            detectiveReportNameDuration = CustomOption.Create(124,Types.Crewmate, "��̽��ñ���ʬ������ʾ��������", 0, 0, 60, 2.5f, detectiveSpawnRate);
            detectiveReportColorDuration = CustomOption.Create(125,Types.Crewmate, "��̽��ñ���ʬ������ʾ������ɫ", 20, 0, 120, 2.5f, detectiveSpawnRate);

            timeMasterSpawnRate = CustomOption.Create(130,Types.Crewmate, cs(TimeMaster.color, "ʱ���ʦ���ɸ���"), rates, null, true);
            timeMasterCooldown = CustomOption.Create(131,Types.Crewmate, "ʱ���ʦ������ȴ", 30f, 10f, 120f, 2.5f, timeMasterSpawnRate);
            timeMasterRewindTime = CustomOption.Create(132,Types.Crewmate, "����ʱ��", 3f, 1f, 10f, 1f, timeMasterSpawnRate);
            timeMasterShieldDuration = CustomOption.Create(133,Types.Crewmate, "ʱ�令�ܳ���ʱ��", 3f, 1f, 20f, 1f, timeMasterSpawnRate);

            medicSpawnRate = CustomOption.Create(140,Types.Crewmate, cs(Medic.color, "ҽ�����ɸ���"), rates, null, true);
            medicShowShielded = CustomOption.Create(143,Types.Crewmate, "ҽ�����ܿɼ�����", new string[] {"������", "����Ŀ�� + ҽ��", "ҽ��"}, medicSpawnRate);
            medicShowAttemptToShielded = CustomOption.Create(144,Types.Crewmate, "�����ܵ�Ŀ���ܿ�����ɱ����", false, medicSpawnRate);
            medicSetOrShowShieldAfterMeeting  = CustomOption.Create(145,Types.Crewmate, "���ܻ������Ч", false, medicSpawnRate);
            medicShowAttemptToMedic = CustomOption.Create(146,Types.Crewmate, "ҽ�����Կ����Ի���Ŀ��Ļ�ɱ����", false, medicSpawnRate);

            swapperSpawnRate = CustomOption.Create(150,Types.Crewmate, cs(Swapper.color, "��Ʊʦ���ɸ���"), rates, null, true);
            swapperCanCallEmergency = CustomOption.Create(151,Types.Crewmate, "��Ʊʦ���ٿ���������", false, swapperSpawnRate);
            swapperCanOnlySwapOthers = CustomOption.Create(152,Types.Crewmate, "��Ʊʦֻ�ɽ������˵ĵ�Ʊ", false, swapperSpawnRate);
            swapperSwapsNumber = CustomOption.Create(153, Types.Crewmate, "��ʼ��Ʊ����", 1f, 0f, 5f, 1f, swapperSpawnRate);
            swapperRechargeTasksNumber = CustomOption.Create(154, Types.Crewmate, "��ɶ�������ɳ���һ�λ�Ʊ����", 2f, 1f, 10f, 1f, swapperSpawnRate);

            seerSpawnRate = CustomOption.Create(160,Types.Crewmate, cs(Seer.color, "��֪���ɸ���"), rates, null, true);
            seerMode = CustomOption.Create(161,Types.Crewmate, "��֪ģʽ", new string[]{ "��ʾ�������� + ���", "��ʾ��������", "��ʾ���"}, seerSpawnRate);
            seerLimitSoulDuration = CustomOption.Create(163,Types.Crewmate, "������֪�Ŀɼ����ʱ��", false, seerSpawnRate);
            seerSoulDuration = CustomOption.Create(162,Types.Crewmate, "��֪�ɼ����ʱ��", 15f, 0f, 120f, 5f, seerLimitSoulDuration);
        
            hackerSpawnRate = CustomOption.Create(170,Types.Crewmate, cs(Hacker.color, "�������ɸ���"), rates, null, true);
            hackerCooldown = CustomOption.Create(171,Types.Crewmate, "���뼼����ȴ", 30f, 5f, 60f, 5f, hackerSpawnRate);
            hackerHackeringDuration = CustomOption.Create(172,Types.Crewmate, "�������ʱ��", 10f, 2.5f, 60f, 2.5f, hackerSpawnRate);
            hackerOnlyColorType = CustomOption.Create(173,Types.Crewmate, "����֮�ɼ���ɫ��ǳ", false, hackerSpawnRate);
            hackerToolsNumber = CustomOption.Create(174,Types.Crewmate, "����ƶ�װ�ó��ܴ���", 5f, 1f, 30f, 1f, hackerSpawnRate);
            hackerRechargeTasksNumber = CustomOption.Create(175,Types.Crewmate, "�ƶ�װ�ó�������������", 2f, 1f, 5f, 1f, hackerSpawnRate);
            hackerNoMove = CustomOption.Create(176,Types.Crewmate, "ʹ���ƶ�װ��ʱ�޷��ƶ�", true, hackerSpawnRate);

            trackerSpawnRate = CustomOption.Create(200,Types.Crewmate, cs(Tracker.color, "׷�������ɸ���"), rates, null, true);
            trackerUpdateIntervall = CustomOption.Create(201,Types.Crewmate, "׷�ټ�ͷ���¼��", 5f, 1f, 30f, 1f, trackerSpawnRate);
            trackerResetTargetAfterMeeting = CustomOption.Create(202,Types.Crewmate, "׷���߻�������ѡ׷��Ŀ��", false, trackerSpawnRate);
            trackerCanTrackCorpses = CustomOption.Create(203,Types.Crewmate, "׷���߿�׷��ʬ��", true, trackerSpawnRate);
            trackerCorpsesTrackingCooldown = CustomOption.Create(204,Types.Crewmate, "׷��ʬ����ȴ", 30f, 5f, 120f, 5f, trackerCanTrackCorpses);
            trackerCorpsesTrackingDuration = CustomOption.Create(205,Types.Crewmate, "׷��ʬ�����ʱ��", 5f, 2.5f, 30f, 2.5f, trackerCanTrackCorpses);
                           
            snitchSpawnRate = CustomOption.Create(210,Types.Crewmate, cs(Snitch.color, "���������ɸ���"), rates, null, true);
            snitchLeftTasksForReveal = CustomOption.Create(211,Types.Crewmate, "�����߻�ʣ��������ʱ�ᱩ¶", 1f, 0f, 5f, 1f, snitchSpawnRate);
            snitchIncludeTeamJackal = CustomOption.Create(212,Types.Crewmate, "�Ƿ��׷�ٲ�����Ӫ", false, snitchSpawnRate);
            snitchTeamJackalUseDifferentArrowColor = CustomOption.Create(213,Types.Crewmate, "ʹ�ò�ͬ��ɫ�ļ�ͷ����ʾ������Ӫ", true, snitchIncludeTeamJackal);

            spySpawnRate = CustomOption.Create(240,Types.Crewmate, cs(Spy.color, "������ɸ���"), rates, null, true);
            spyCanDieToSheriff = CustomOption.Create(241,Types.Crewmate, "����ɱ�����ɱ��", false, spySpawnRate);
            spyImpostorsCanKillAnyone = CustomOption.Create(242,Types.Crewmate, "����м�����ڣ��ڹ��ɱ���κ���", true, spySpawnRate);
            spyCanEnterVents = CustomOption.Create(243,Types.Crewmate, "�����������ܵ�", false, spySpawnRate);
            spyHasImpostorVision = CustomOption.Create(244,Types.Crewmate, "���ӵ���ڹ���Ұ", false, spySpawnRate);

            portalmakerSpawnRate = CustomOption.Create(390, Types.Crewmate, cs(Portalmaker.color, "���������������ɸ���"), rates, null, true);
            portalmakerCooldown = CustomOption.Create(391, Types.Crewmate, "���촫������ȴ", 30f, 10f, 60f, 2.5f, portalmakerSpawnRate);
            portalmakerUsePortalCooldown = CustomOption.Create(392, Types.Crewmate, "ʹ�ô�������ȴ", 30f, 10f, 60f, 2.5f, portalmakerSpawnRate);
            portalmakerLogOnlyColorType = CustomOption.Create(393, Types.Crewmate, "���ͼ�¼ֻ��ʾ��ɫ��ǳ", true, portalmakerSpawnRate);
            portalmakerLogHasTime = CustomOption.Create(394, Types.Crewmate, "���ͼ�¼��ʱ����Ϣ", true, portalmakerSpawnRate);
            
            securityGuardSpawnRate = CustomOption.Create(280,Types.Crewmate, cs(SecurityGuard.color, "�������ɸ���"), rates, null, true);
            securityGuardCooldown = CustomOption.Create(281,Types.Crewmate, "����������ȴ", 30f, 10f, 60f, 2.5f, securityGuardSpawnRate);
            securityGuardTotalScrews = CustomOption.Create(282,Types.Crewmate, "����ӵ����˿����", 7f, 1f, 15f, 1f, securityGuardSpawnRate);
            securityGuardCamPrice = CustomOption.Create(283,Types.Crewmate, "��������ͷ���ĵ���˿������", 2f, 1f, 15f, 1f, securityGuardSpawnRate);
            securityGuardVentPrice = CustomOption.Create(284,Types.Crewmate, "��չܵ����ĵ���˿������", 1f, 1f, 15f, 1f, securityGuardSpawnRate);
            securityGuardCamDuration = CustomOption.Create(285,Types.Crewmate, "����ʹ�ü��ܳ���ʱ��", 10f, 2.5f, 60f, 2.5f, securityGuardSpawnRate);
            securityGuardCamMaxCharges = CustomOption.Create(286,Types.Crewmate, "��˿����󲹳�����", 5f, 1f, 30f, 1f, securityGuardSpawnRate);
            securityGuardCamRechargeTasksNumber = CustomOption.Create(287,Types.Crewmate, "������˿����Ҫ����������", 3f, 1f, 10f, 1f, securityGuardSpawnRate);
            securityGuardNoMove = CustomOption.Create(288,Types.Crewmate, "������������ͷʱ��ͣ��ʱ��", true, securityGuardSpawnRate);
            
            mediumSpawnRate = CustomOption.Create(360,Types.Crewmate, cs(Medium.color, "ͨ��ʦ���ɸ���"), rates, null, true);
            mediumCooldown = CustomOption.Create(361,Types.Crewmate, "ͨ��ʦ������ȴ", 30f, 5f, 120f, 5f, mediumSpawnRate);
            mediumDuration = CustomOption.Create(362,Types.Crewmate, "ͨ��ʦ���ʳ���ʱ��", 3f, 0f, 15f, 1f, mediumSpawnRate);
            mediumOneTimeUse = CustomOption.Create(363,Types.Crewmate, "ÿ�����ֻ�ɱ�����һ��", false, mediumSpawnRate);
            
            // Modifier
            modifierBloody = CustomOption.Create(1000, Types.Modifier, cs(Color.yellow, "Ѫ���ܵ����ɸ���"), rates, null, true);
            modifierBloodyQuantity = CustomOption.Create(1001, Types.Modifier, cs(Color.yellow, "Ѫ���ܵ�����"), ratesModifier, modifierBloody);
            modifierBloodyDuration = CustomOption.Create(1002, Types.Modifier, "Ѫ������ʱ��", 10f, 3f, 60f, 1f, modifierBloody);

            modifierAntiTeleport = CustomOption.Create(1010, Types.Modifier, cs(Color.yellow, "ͣ�͵����ɸ���"), rates, null, true);
            modifierAntiTeleportQuantity = CustomOption.Create(1011, Types.Modifier, cs(Color.yellow, "ͣ�͵�����"), ratesModifier, modifierAntiTeleport);

            modifierTieBreaker = CustomOption.Create(1020, Types.Modifier, cs(Color.yellow, "�þ������ɸ���"), rates, null, true);
            
            modifierBait = CustomOption.Create(1030, Types.Modifier, cs(Color.yellow, "�ն������ɸ���"), rates, null, true);
            modifierBaitQuantity = CustomOption.Create(1031, Types.Modifier, cs(Color.yellow, "�ն�������"), ratesModifier, modifierBait);
            modifierBaitReportDelayMin = CustomOption.Create(1032, Types.Modifier, "�ն����ӳٱ������ʱ��", 0f, 0f, 10f, 1f, modifierBait);
            modifierBaitReportDelayMax = CustomOption.Create(1033, Types.Modifier, "�ն����ӳٱ������ʱ��", 0f, 0f, 10f, 1f, modifierBait);
            modifierBaitShowKillFlash = CustomOption.Create(1034, Types.Modifier, "�Ƿ������⾯��ɱ����", true, modifierBait);

            modifierLover = CustomOption.Create(1040, Types.Modifier, cs(Color.yellow, "���������ɸ���"), rates, null, true);
            modifierLoverImpLoverRate = CustomOption.Create(1041, Types.Modifier, "��һ���������ڹ�ĸ���", rates, modifierLover);
            modifierLoverBothDie = CustomOption.Create(1042, Types.Modifier, "���˹���", true, modifierLover);
            modifierLoverEnableChat = CustomOption.Create(1043, Types.Modifier, "��������˽��", true, modifierLover);

            modifierSunglasses = CustomOption.Create(1050, Types.Modifier, cs(Color.yellow, "Ŀä�����ɸ���"), rates, null, true);
            modifierSunglassesQuantity = CustomOption.Create(1051, Types.Modifier, cs(Color.yellow, "Ŀä������"), ratesModifier, modifierSunglasses);
            modifierSunglassesVision = CustomOption.Create(1052, Types.Modifier, "Ŀä����Ұ��Χ", new string[] { "-10%", "-20%", "-30%", "-40%", "-50%" }, modifierSunglasses);

            modifierMini = CustomOption.Create(1061, Types.Modifier, cs(Color.yellow, "��������ɸ���"), rates, null, true);
            modifierMiniGrowingUpDuration = CustomOption.Create(1062, Types.Modifier, "����ĳ���ʱ��", 400f, 100f, 1500f, 100f, modifierMini);

            modifierVip = CustomOption.Create(1070, Types.Modifier, cs(Color.yellow, "�������ɸ���"), rates, null, true);
            modifierVipQuantity = CustomOption.Create(1071, Types.Modifier, cs(Color.yellow, "��������"), ratesModifier, modifierVip);
            modifierVipShowColor = CustomOption.Create(1072, Types.Modifier, "��ʾ���Ķ�����ɫ", true, modifierVip);

            modifierInvert = CustomOption.Create(1080, Types.Modifier, cs(Color.yellow, "�ߵ������ɸ���"), rates, null, true);
            modifierInvertQuantity = CustomOption.Create(1081, Types.Modifier, cs(Color.yellow, "�ߵ�������"), ratesModifier, modifierInvert);
            modifierInvertDuration = CustomOption.Create(1082, Types.Modifier, "�ߵ��ĳ������ֻ���", 3f, 1f, 15f, 1f, modifierInvert);

            // Other options

            maxNumberOfMeetings = CustomOption.Create(3,Types.General, "�����������г�������⣩", 10, 0, 15, 1, null, true);
            blockSkippingInEmergencyMeetings = CustomOption.Create(4,Types.General, "���������н�ֹ����", false);
            noVoteIsSelfVote = CustomOption.Create(5,Types.General, "���ܸ��Լ�ͶƱ", false, blockSkippingInEmergencyMeetings);
            hidePlayerNames = CustomOption.Create(6,Types.General, "�����������", false);
            allowParallelMedBayScans = CustomOption.Create(7,Types.General, "����ͬʱ����ɨ������", false);
            shieldFirstKill = CustomOption.Create(8, Types.General, "�����׵�����", false);

            dynamicMap = CustomOption.Create(500,Types.General, "�����ͼ����", false, null, false);
            dynamicMapEnableSkeld = CustomOption.Create(501,Types.General, "Skeld��������б�", true, dynamicMap, false);
            dynamicMapEnableMira = CustomOption.Create(502,Types.General, "Mira��������б�", true, dynamicMap, false);
            dynamicMapEnablePolus = CustomOption.Create(503,Types.General, "Polus��������б�", true, dynamicMap, false);
            dynamicMapEnableAirShip = CustomOption.Create(504,Types.General, "Airship��������б�", true, dynamicMap, false);
            
            dynamicMapEnableSubmerged = CustomOption.Create(505, Types.General, "Submerged�����漴�б�", true, dynamicMap, false);

            blockedRolePairings.Add((byte)RoleId.Vampire, new [] { (byte)RoleId.Warlock});
            blockedRolePairings.Add((byte)RoleId.Warlock, new [] { (byte)RoleId.Vampire});
            blockedRolePairings.Add((byte)RoleId.Spy, new [] { (byte)RoleId.Mini});
            blockedRolePairings.Add((byte)RoleId.Mini, new [] { (byte)RoleId.Spy});
            blockedRolePairings.Add((byte)RoleId.Vulture, new [] { (byte)RoleId.Cleaner});
            blockedRolePairings.Add((byte)RoleId.Cleaner, new [] { (byte)RoleId.Vulture});
            
        }
    }
}
