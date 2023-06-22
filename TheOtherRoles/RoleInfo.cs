using System.Linq;
using System;
using System.Collections.Generic;
using TheOtherRoles.Players;
using static TheOtherRoles.TheOtherRoles;
using UnityEngine;
using TheOtherRoles.Utilities;
using TheOtherRoles.CustomGameModes;

namespace TheOtherRoles
{
    public class RoleInfo {
        public Color color;
        public string name;
        public string introDescription;
        public string shortDescription;
        public RoleId roleId;
        public bool isNeutral;
        public bool isModifier;

        public RoleInfo(string name, Color color, string introDescription, string shortDescription, RoleId roleId, bool isNeutral = false, bool isModifier = false) {
            this.color = color;
            this.name = name;
            this.introDescription = introDescription;
            this.shortDescription = shortDescription;
            this.roleId = roleId;
            this.isNeutral = isNeutral;
            this.isModifier = isModifier;
        }

        public static RoleInfo jester = new RoleInfo("小丑", Jester.color, "想办法被投出去", "被投出去", RoleId.Jester, true);
        public static RoleInfo mayor = new RoleInfo("市长", Mayor.color, "你的一票记作两票", "你的一票记作两票", RoleId.Mayor);
		public static RoleInfo portalmaker = new RoleInfo("传送门制造者", Portalmaker.color, "你可以制造传送门", "你可以制造传送门", RoleId.Portalmaker);
        public static RoleInfo engineer = new RoleInfo("工程师",  Engineer.color, "保护飞船上的重要设施", "修复飞船", RoleId.Engineer);
        public static RoleInfo sheriff = new RoleInfo("警长", Sheriff.color, "射杀<color=#FF1919FF>内鬼</color>", "射杀内鬼", RoleId.Sheriff);
        public static RoleInfo deputy = new RoleInfo("警员", Sheriff.color, "给<color=#FF1919FF>内鬼戴上手铐</color>", "给内鬼戴上手铐", RoleId.Deputy);
        public static RoleInfo lighter = new RoleInfo("秉烛者", Lighter.color, "你的烛光永不熄灭", "你的烛光永不熄灭", RoleId.Lighter);
        public static RoleInfo godfather = new RoleInfo("教父", Godfather.color, "杀死所有船员", "杀死所有船员", RoleId.Godfather);
        public static RoleInfo mafioso = new RoleInfo("小弟", Mafioso.color, "作为<color=#FF1919FF>黑手党</color>的成员杀死所有船员", "杀死所有船员", RoleId.Mafioso);
        public static RoleInfo janitor = new RoleInfo("清洁工", Janitor.color, "作为<color=#FF1919FF>黑手党</color>的成员，清理死尸", "清理尸体", RoleId.Janitor);
        public static RoleInfo morphling = new RoleInfo("化形者", Morphling.color, "改变你的外貌来逃避追捕", "改变外貌", RoleId.Morphling);
        public static RoleInfo camouflager = new RoleInfo("伪装者", Camouflager.color, "伪装并杀死船员", "在人群之中隐藏自己", RoleId.Camouflager);
        public static RoleInfo vampire = new RoleInfo("吸血鬼", Vampire.color, "咬船员来杀死他们", "咬你的敌人", RoleId.Vampire);
        public static RoleInfo eraser = new RoleInfo("抹除者", Eraser.color, "杀死船员，清除他们的身份", "清除你敌人的身份", RoleId.Eraser);
        public static RoleInfo trickster = new RoleInfo("诡术师", Trickster.color, "使用你的诡计盒来欺骗别人", "给你的敌人一个惊喜", RoleId.Trickster);
        public static RoleInfo cleaner = new RoleInfo("清理者", Cleaner.color, "不留痕迹的杀死所有人", "清理尸体", RoleId.Cleaner);
        public static RoleInfo warlock = new RoleInfo("术士", Warlock.color, "诅咒其他玩家并杀死所有人", "诅咒其他玩家并杀死所有人", RoleId.Warlock);
        public static RoleInfo bountyHunter = new RoleInfo("赏金猎人", BountyHunter.color, "追猎赏金目标", "追猎赏金目标", RoleId.BountyHunter);
        public static RoleInfo detective = new RoleInfo("侦探", Detective.color, "通过调查脚印来找到<color=#FF1919FF>内鬼</color>", "检查脚印", RoleId.Detective);
        public static RoleInfo timeMaster = new RoleInfo("时间大师", TimeMaster.color, "使用时间护盾保护自己", "使用时间护盾保护自己", RoleId.TimeMaster);
        public static RoleInfo medic = new RoleInfo("医生", Medic.color, "使用护盾保护别人", "使用护盾保护别人", RoleId.Medic);
        public static RoleInfo swapper = new RoleInfo("换票师", Swapper.color, "交换得票来流放<color=#FF1919FF>内鬼</color>", "交换得票", RoleId.Swapper);
        public static RoleInfo seer = new RoleInfo("先知", Seer.color, "你可以看到其他玩家死亡", "你可以看到其他玩家死亡", RoleId.Seer);
        public static RoleInfo hacker = new RoleInfo("骇客", Hacker.color, "骇入系统来找到<color=#FF1919FF>内鬼</color>", "骇入来找到内鬼", RoleId.Hacker);
        public static RoleInfo tracker = new RoleInfo("追踪者", Tracker.color, "追踪<color=#FF1919FF>内鬼</color>", "追踪内鬼", RoleId.Tracker);
        public static RoleInfo snitch = new RoleInfo("告密者", Snitch.color, "完成任务来找出<color=#FF1919FF>内鬼</color>", "完成任务", RoleId.Snitch);
        public static RoleInfo jackal = new RoleInfo("豺狼", Jackal.color, "杀死所有的船员和<color=#FF1919FF>内鬼</color>来获得胜利", "把他们全杀了", RoleId.Jackal, true);
        public static RoleInfo sidekick = new RoleInfo("走狗", Sidekick.color, "帮助豺狼杀死所有人", "帮助豺狼杀死所有人", RoleId.Sidekick, true);
        public static RoleInfo spy = new RoleInfo("间谍", Spy.color, "迷惑<color=#FF1919FF>内鬼</color>", "迷惑内鬼", RoleId.Spy);
        public static RoleInfo securityGuard = new RoleInfo("保安", SecurityGuard.color, "封住管道，安放摄像头", "封住管道，安放摄像头", RoleId.SecurityGuard);
        public static RoleInfo arsonist = new RoleInfo("纵火犯", Arsonist.color, "让世界熊熊燃烧", "让世界熊熊燃烧", RoleId.Arsonist, true);
        public static RoleInfo goodGuesser = new RoleInfo("正义的赌怪", Guesser.color, "赌就完事了", "赌就完事了", RoleId.NiceGuesser);
        public static RoleInfo badGuesser = new RoleInfo("邪恶的赌怪", Palette.ImpostorRed, "赌就完事了", "赌就完事了", RoleId.EvilGuesser);
        public static RoleInfo vulture = new RoleInfo("秃鹫", Vulture.color, "食用尸体来获得胜利", "吃尸体", RoleId.Vulture, true);
        public static RoleInfo medium = new RoleInfo("通灵师", Medium.color, "询问灵魂问题来获得信息", "询问灵魂", RoleId.Medium);
        public static RoleInfo trapper = new RoleInfo("陷阱师", Trapper.color, "释放陷阱来找到内鬼", "释放陷阱", RoleId.Trapper);
        public static RoleInfo lawyer = new RoleInfo("律师", Lawyer.color, "为你的客户辩护", "为你的客户辩护", RoleId.Lawyer, true);
        public static RoleInfo prosecutor = new RoleInfo("检察官", Lawyer.color, "投出你的目标", "投出你的目标", RoleId.Prosecutor, true);
        public static RoleInfo pursuer = new RoleInfo("起诉人", Pursuer.color, "给内鬼塞空包弹，活下去", "给内鬼塞空包弹，活下去", RoleId.Pursuer);
        public static RoleInfo impostor = new RoleInfo("内鬼", Palette.ImpostorRed, Helpers.cs(Palette.ImpostorRed, "破坏或杀死所有人"), "破坏或杀死所有人", RoleId.Impostor);
        public static RoleInfo crewmate = new RoleInfo("船员", Color.white, "找到内鬼", "找到内鬼", RoleId.Crewmate);
        public static RoleInfo witch = new RoleInfo("女巫", Witch.color, "对你的敌人施咒", "对你的敌人施咒", RoleId.Witch);
        public static RoleInfo ninja = new RoleInfo("忍者", Ninja.color, "出其不意暗杀敌人", "出其不意暗杀敌人", RoleId.Ninja);
        public static RoleInfo thief = new RoleInfo("Thief", Thief.color, "Steal a killers role by killing them", "Steal a killers role", RoleId.Thief, true);
        public static RoleInfo bomber = new RoleInfo("Bomber", Bomber.color, "Bomb all Crewmates", "Bomb all Crewmates", RoleId.Bomber);

        public static RoleInfo hunter = new RoleInfo("Hunter", Palette.ImpostorRed, Helpers.cs(Palette.ImpostorRed, "Seek and kill everyone"), "Seek and kill everyone", RoleId.Impostor);
        public static RoleInfo hunted = new RoleInfo("Hunted", Color.white, "Hide", "Hide", RoleId.Crewmate);



        // Modifier
        public static RoleInfo bloody = new RoleInfo("血淋淋的", Color.yellow, "杀死你的人将会留下血迹", "杀死你的人将会留下血迹", RoleId.Bloody, false, true);
        public static RoleInfo antiTeleport = new RoleInfo("停滞的", Color.yellow, "你不会被传送", "你不会被传送", RoleId.AntiTeleport, false, true);
        public static RoleInfo tiebreaker = new RoleInfo("裁决的", Color.yellow, "由你裁定平票", "打破僵局", RoleId.Tiebreaker, false, true);
        public static RoleInfo bait = new RoleInfo("诱饵的", Color.yellow, "引诱你的敌人", "引诱你的敌人", RoleId.Bait, false, true);
        public static RoleInfo sunglasses = new RoleInfo("目盲的", Color.yellow, "你瞎了", "你的视野范围缩小了", RoleId.Sunglasses, false, true);
        public static RoleInfo lover = new RoleInfo("热恋的", Lovers.color, $"你们相爱了", $"你们相爱了", RoleId.Lover, false, true);
        public static RoleInfo mini = new RoleInfo("迷你的", Color.yellow, "在你长大前没人可以杀死你", "没人可以伤害你", RoleId.Mini, false, true);
        public static RoleInfo vip = new RoleInfo("尊贵的", Color.yellow, "你是尊贵的", "所有人都会知道你死了", RoleId.Vip, false, true);
        public static RoleInfo invert = new RoleInfo("颠倒的", Color.yellow, "你的操作是反向的", "你的移动是反向的", RoleId.Invert, false, true);
        public static RoleInfo chameleon = new RoleInfo("拟态的", Color.yellow, "你很难知道什么时候该移动", "你看不清什么动了", RoleId.Chameleon, false, true);
        public static RoleInfo shifter = new RoleInfo("交换的", Color.yellow, "交换你的角色", "交换你的角色", RoleId.Shifter, false, true);


        public static List<RoleInfo> allRoleInfos = new List<RoleInfo>() {
            impostor,
            godfather,
            mafioso,
            janitor,
            morphling,
            camouflager,
            vampire,
            eraser,
            trickster,
            cleaner,
            warlock,
            bountyHunter,
            witch,
            ninja,
            bomber,
            goodGuesser,
            badGuesser,
            lover,
            jester,
            arsonist,
            jackal,
            sidekick,
            vulture,
            pursuer,
            lawyer,
            thief,
            prosecutor,
            crewmate,
            mayor,
            portalmaker,
            engineer,
            sheriff,
            deputy,
            lighter,
            detective,
            timeMaster,
            medic,
            swapper,
            seer,
            hacker,
            tracker,
            snitch,
            spy,
            securityGuard,
            bait,
            medium,
            trapper,
            bloody,
            antiTeleport,
            tiebreaker,
            sunglasses,
            mini,
            vip,
            invert,
            chameleon,
            shifter
        };

        public static List<RoleInfo> getRoleInfoForPlayer(PlayerControl p, bool showModifier = true) {
            List<RoleInfo> infos = new List<RoleInfo>();
            if (p == null) return infos;

            // Modifier
            if (showModifier) {
                // after dead modifier
                if (!CustomOptionHolder.modifiersAreHidden.getBool() || PlayerControl.LocalPlayer.Data.IsDead || AmongUsClient.Instance.GameState == InnerNet.InnerNetClient.GameStates.Ended)
                {
                    if (Bait.bait.Any(x => x.PlayerId == p.PlayerId)) infos.Add(bait);
                    if (Bloody.bloody.Any(x => x.PlayerId == p.PlayerId)) infos.Add(bloody);
                    if (Vip.vip.Any(x => x.PlayerId == p.PlayerId)) infos.Add(vip);
                }
                if (p == Lovers.lover1 || p == Lovers.lover2) infos.Add(lover);
                if (p == Tiebreaker.tiebreaker) infos.Add(tiebreaker);
                if (AntiTeleport.antiTeleport.Any(x => x.PlayerId == p.PlayerId)) infos.Add(antiTeleport);
                if (Sunglasses.sunglasses.Any(x => x.PlayerId == p.PlayerId)) infos.Add(sunglasses);
                if (p == Mini.mini) infos.Add(mini);
                if (Invert.invert.Any(x => x.PlayerId == p.PlayerId)) infos.Add(invert);
                if (Chameleon.chameleon.Any(x => x.PlayerId == p.PlayerId)) infos.Add(chameleon);
                if (p == Shifter.shifter) infos.Add(shifter);
            }

            int count = infos.Count;  // Save count after modifiers are added so that the role count can be checked

            // Special roles
            if (p == Jester.jester) infos.Add(jester);
            if (p == Mayor.mayor) infos.Add(mayor);
            if (p == Portalmaker.portalmaker) infos.Add(portalmaker);
            if (p == Engineer.engineer) infos.Add(engineer);
            if (p == Sheriff.sheriff || p == Sheriff.formerSheriff) infos.Add(sheriff);
            if (p == Deputy.deputy) infos.Add(deputy);
            if (p == Lighter.lighter) infos.Add(lighter);
            if (p == Godfather.godfather) infos.Add(godfather);
            if (p == Mafioso.mafioso) infos.Add(mafioso);
            if (p == Janitor.janitor) infos.Add(janitor);
            if (p == Morphling.morphling) infos.Add(morphling);
            if (p == Camouflager.camouflager) infos.Add(camouflager);
            if (p == Vampire.vampire) infos.Add(vampire);
            if (p == Eraser.eraser) infos.Add(eraser);
            if (p == Trickster.trickster) infos.Add(trickster);
            if (p == Cleaner.cleaner) infos.Add(cleaner);
            if (p == Warlock.warlock) infos.Add(warlock);
            if (p == Witch.witch) infos.Add(witch);
            if (p == Ninja.ninja) infos.Add(ninja);
            if (p == Bomber.bomber) infos.Add(bomber);
            if (p == Detective.detective) infos.Add(detective);
            if (p == TimeMaster.timeMaster) infos.Add(timeMaster);
            if (p == Medic.medic) infos.Add(medic);
            if (p == Swapper.swapper) infos.Add(swapper);
            if (p == Seer.seer) infos.Add(seer);
            if (p == Hacker.hacker) infos.Add(hacker);
            if (p == Tracker.tracker) infos.Add(tracker);
            if (p == Snitch.snitch) infos.Add(snitch);
            if (p == Jackal.jackal || (Jackal.formerJackals != null && Jackal.formerJackals.Any(x => x.PlayerId == p.PlayerId))) infos.Add(jackal);
            if (p == Sidekick.sidekick) infos.Add(sidekick);
            if (p == Spy.spy) infos.Add(spy);
            if (p == SecurityGuard.securityGuard) infos.Add(securityGuard);
            if (p == Arsonist.arsonist) infos.Add(arsonist);
            if (p == Guesser.niceGuesser) infos.Add(goodGuesser);
            if (p == Guesser.evilGuesser) infos.Add(badGuesser);
            if (p == BountyHunter.bountyHunter) infos.Add(bountyHunter);
            if (p == Vulture.vulture) infos.Add(vulture);
            if (p == Medium.medium) infos.Add(medium);
            if (p == Lawyer.lawyer && !Lawyer.isProsecutor) infos.Add(lawyer);
            if (p == Lawyer.lawyer && Lawyer.isProsecutor) infos.Add(prosecutor);
            if (p == Trapper.trapper) infos.Add(trapper);
            if (p == Pursuer.pursuer) infos.Add(pursuer);
            if (p == Thief.thief) infos.Add(thief);

            // Default roles (just impostor, just crewmate, or hunter / hunted for hide n seek
            if (infos.Count == count) {
                if (p.Data.Role.IsImpostor)
                    infos.Add(TORMapOptions.gameMode == CustomGamemodes.HideNSeek ? RoleInfo.hunter : RoleInfo.impostor);
                else
                    infos.Add(TORMapOptions.gameMode == CustomGamemodes.HideNSeek ? RoleInfo.hunted : RoleInfo.crewmate);
            }

            return infos;
        }

        public static String GetRolesString(PlayerControl p, bool useColors, bool showModifier = true, bool suppressGhostInfo = false) {
            string roleName;
            roleName = String.Join(" ", getRoleInfoForPlayer(p, showModifier).Select(x => useColors ? Helpers.cs(x.color, x.name) : x.name).ToArray());
            if (Lawyer.target != null && p.PlayerId == Lawyer.target.PlayerId && CachedPlayer.LocalPlayer.PlayerControl != Lawyer.target) 
                roleName += (useColors ? Helpers.cs(Pursuer.color, " §") : " §");
            if (HandleGuesser.isGuesserGm && HandleGuesser.isGuesser(p.PlayerId)) roleName += " (Guesser)";

            if (!suppressGhostInfo && p != null) {
                if (p == Shifter.shifter && (CachedPlayer.LocalPlayer.PlayerControl == Shifter.shifter || Helpers.shouldShowGhostInfo()) && Shifter.futureShift != null)
                    roleName += Helpers.cs(Color.yellow, " ← " + Shifter.futureShift.Data.PlayerName);
                if (p == Vulture.vulture && (CachedPlayer.LocalPlayer.PlayerControl == Vulture.vulture || Helpers.shouldShowGhostInfo()))
                    roleName = roleName + Helpers.cs(Vulture.color, $" ({Vulture.vultureNumberToWin - Vulture.eatenBodies} left)");
                if (Helpers.shouldShowGhostInfo()) {
                    if (Eraser.futureErased.Contains(p))
                        roleName = Helpers.cs(Color.gray, "(erased) ") + roleName;
                    if (Vampire.vampire != null && !Vampire.vampire.Data.IsDead && Vampire.bitten == p && !p.Data.IsDead)
                        roleName = Helpers.cs(Vampire.color, $"(bitten {(int)HudManagerStartPatch.vampireKillButton.Timer + 1}) ") + roleName;
                    if (Deputy.handcuffedPlayers.Contains(p.PlayerId))
                        roleName = Helpers.cs(Color.gray, "(cuffed) ") + roleName;
                    if (Deputy.handcuffedKnows.ContainsKey(p.PlayerId))  // Active cuff
                        roleName = Helpers.cs(Deputy.color, "(cuffed) ") + roleName;
                    if (p == Warlock.curseVictim)
                        roleName = Helpers.cs(Warlock.color, "(cursed) ") + roleName;
                    if (p == Ninja.ninjaMarked)
                        roleName = Helpers.cs(Ninja.color, "(marked) ") + roleName;
                    if (Pursuer.blankedList.Contains(p) && !p.Data.IsDead)
                        roleName = Helpers.cs(Pursuer.color, "(blanked) ") + roleName;
                    if (Witch.futureSpelled.Contains(p) && !MeetingHud.Instance) // This is already displayed in meetings!
                        roleName = Helpers.cs(Witch.color, "☆ ") + roleName;
                    if (BountyHunter.bounty == p)
                        roleName = Helpers.cs(BountyHunter.color, "(bounty) ") + roleName;
                    if (Arsonist.dousedPlayers.Contains(p))
                        roleName = Helpers.cs(Arsonist.color, "♨ ") + roleName;
                    if (p == Arsonist.arsonist)
                        roleName = roleName + Helpers.cs(Arsonist.color, $" ({CachedPlayer.AllPlayers.Count(x => { return x.PlayerControl != Arsonist.arsonist && !x.Data.IsDead && !x.Data.Disconnected && !Arsonist.dousedPlayers.Any(y => y.PlayerId == x.PlayerId); })} left)");
                    if (p == Jackal.fakeSidekick)
                        roleName = Helpers.cs(Sidekick.color, $" (fake SK)") + roleName;
                    // Death Reason on Ghosts
                    if (p.Data.IsDead) {
                        string deathReasonString = "";
                        var deadPlayer = GameHistory.deadPlayers.FirstOrDefault(x => x.player.PlayerId == p.PlayerId);

                        Color killerColor = new();
                        if (deadPlayer != null && deadPlayer.killerIfExisting != null) {
                            killerColor = RoleInfo.getRoleInfoForPlayer(deadPlayer.killerIfExisting, false).FirstOrDefault().color;
                        }

                        if (deadPlayer != null) {
                            switch (deadPlayer.deathReason) {
                                case DeadPlayer.CustomDeathReason.Disconnect:
                                    deathReasonString = " - disconnected";
                                    break;
                                case DeadPlayer.CustomDeathReason.Exile:
                                    deathReasonString = " - voted out";
                                    break;
                                case DeadPlayer.CustomDeathReason.Kill:
                                    deathReasonString = $" - killed by {Helpers.cs(killerColor, deadPlayer.killerIfExisting.Data.PlayerName)}";
                                    break;
                                case DeadPlayer.CustomDeathReason.Guess:
                                    if (deadPlayer.killerIfExisting.Data.PlayerName == p.Data.PlayerName)
                                        deathReasonString = $" - failed guess";
                                    else
                                        deathReasonString = $" - guessed by {Helpers.cs(killerColor, deadPlayer.killerIfExisting.Data.PlayerName)}";
                                    break;
                                case DeadPlayer.CustomDeathReason.Shift:
                                    deathReasonString = $" - {Helpers.cs(Color.yellow, "shifted")} {Helpers.cs(killerColor, deadPlayer.killerIfExisting.Data.PlayerName)}";
                                    break;
                                case DeadPlayer.CustomDeathReason.WitchExile:
                                    deathReasonString = $" - {Helpers.cs(Witch.color, "witched")} by {Helpers.cs(killerColor, deadPlayer.killerIfExisting.Data.PlayerName)}";
                                    break;
                                case DeadPlayer.CustomDeathReason.LoverSuicide:
                                    deathReasonString = $" - {Helpers.cs(Lovers.color, "lover died")}";
                                    break;
                                case DeadPlayer.CustomDeathReason.LawyerSuicide:
                                    deathReasonString = $" - {Helpers.cs(Lawyer.color, "bad Lawyer")}";
                                    break;
                                case DeadPlayer.CustomDeathReason.Bomb:
                                    deathReasonString = $" - bombed by {Helpers.cs(killerColor, deadPlayer.killerIfExisting.Data.PlayerName)}";
                                    break;
                            }
                            roleName = roleName + deathReasonString;
                        }
                    }
                }
            }
            return roleName;
        }
    }
}
