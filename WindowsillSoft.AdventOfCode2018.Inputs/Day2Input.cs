﻿using System;
using System.Collections.Generic;
using System.Text;
using WindowsillSoft.AdventOfCode2018.Solutions.Day2;

namespace WindowsillSoft.AdventOfCode2018.Inputs
{
    public class Day2Input
    {
        public const string Part1Test1Input = @"abcdef
bababc
abbcde
abcccd
aabcdd
abcdee
ababab";
        public const string Part1Test1Result = "12";

        public const string Part2Test1Input = @"abcde
fghij
klmno
pqrst
fguij
axcye
wvxyz";
        public const string Part2Test1Result = "fgij";

        [FullRunInput(typeof(Day2Solver))]
        public const string FullRunInput = @"efmyhuxcqqldtwjzvisepargvo
efuyhuxckqldtwjrvrsbpargno
efmyhuxckqlxtwjxvisbpargoo
efmyhuxczqbdtwjzvisbpargjo
efmyhugckqldtwjzvisfpargnq
tfmyhuxckqljtwjzvisbpargko
efmyhuxckqldtvuzvisbpavgno
efmyhufcrqldtwjzvishpargno
tfmyhuxbkqlduwjzvisbpargno
efayhtxckqldbwjzvisbpargno
efgyhuxckuldtwjzvisbpardno
efmyhuxckuldtwizvisbpargqo
efmyhuxcknldtjjzvihbpargno
efmyhuxcnqddtwjzvisbpafgno
efmyhubokqldtwjzvisbpargdo
efmhhuxckqldtwdzvisbpjrgno
efmyhuxckqldtwjrcisbpargny
efmyhuxckqsdtwjzlisbpargng
effyhuxckqlqtwjzjisbpargno
nfmyhjxckqldtwjzcisbpargno
efmyhvxckqldtwszvwsbpargno
efmyhuxckqldtwutvisbpprgno
kfmyhuxckqldtwzuvisbpargno
efhyhtxckqldtwjmvisbpargno
efmyhuhckqldtwjzvisbpxwgno
efmyhuxcfqldtrjzvitbpargno
efmyhudckqldtwjfvisbparvno
ekmyhuxckqlstwjzvisbdargno
efmyhuxckqlxtwjftisbpargno
etsyhuxckqldtwjzvisbpargnf
exmyhusckqldtwjzvisbpakgno
efmyhubckqlrtljzvisbpargno
efmyhuxckwldtwjovizbpargno
efmyhulckqzdtwjzvisbpargpo
efmyhuxckbcdlwjzvisbpargno
zfmyhulckqbdtwjzvisbpargno
efmyquxckfldtwazvisbpargno
efxyhuxakqldtwjzvisupargno
efmlhuxckkedtwjzvisbpargno
efhyhuxwkqldtwjzvisbparjno
efmyhuxfkqldtwjzvisvparyno
efmyhuxckqfdtijzvisblargno
efmyhuxckqldtfjzvisbwhrgno
efmymuxcknldtwzzvisbpargno
eomybuxckqldtwkzvisbpargno
pfmyhuxckqldtwgzvasbpargno
vfmyhuxcoqldtwjzvisbparvno
eflyhuxckqldtwjzvirypargno
efmyvuxckqldtwizvisbpaqgno
epmyhuxckqldtwjzvesbparpno
efoyhuxckoldtwjmvisbpargno
efmyhuxckqydtwpzvisbpaqgno
efmyhuxckqldezbzvisbpargno
efmyhuxckqldtwjzvisboalxno
efmyhuxckqldtwuzvipbjargno
efmymuxcuqldtwjzvasbpargno
jfmyhuxckqldtwjzvzsbpargdo
nfmyhuxckqlntsjzvisbpargno
efmxhuxckqgdtwjzvisbparjno
efmyhuxckpldtpjzvpsbpargno
efmyhuxcyqldtwjhvisbpargqo
efmyhexgkqydtwjzvisbpargno
ffmyhuxckqldtwjzvisbpafgnk
efmyfuxckqldtwjpvisbpartno
efmyhoxckcmdtwjzvisbpargno
efmyhuxxkqldtwjzviabparyno
jfmyhuxakqldtwgzvisbpargno
efmjhuxckqcdtwjzvisbjargno
efmyhuxccqldtwjzxisbxargno
efmyhurckqldiwjzvrsbpargno
efmyhuxckasdtwjzvisboargno
efmyhvxckmldtwjgvisbpargno
efmyhuxckoldtwjuvisbpardno
efmyduxckqldtwjgvzsbpargno
ejmyhuxckqldtwbzvisbpargnb
efmymuxchqldtwjzvibbpargno
efmyhjxckqldtwjgvinbpargno
efmyhuxhyqldtwbzvisbpargno
efmyhuxckqldtwjzvisbpzignq
efmyuueckqldxwjzvisbpargno
qfmyhyxckqldtwizvisbpargno
efmyhupckqldtwjzvpgbpargno
efmycuxckqldtwjzvfdbpargno
efmyhugcrqldtwjfvisbpargno
efmyhexckqldtwjzvischargno
efmyhuxckqldtljzvasbpamgno
efmyzdxckqldtwjovisbpargno
efmyhuxccqldtwjzvdsbpaigno
ufmyhuxekqldtwjzvisbpargne
efmyhuxckqldfwozvisgpargno
afmyhuackqldtwjzvisbdargno
efmyauxckqldtwjzvisiparmno
efmysuxckqldtwjzvisbeaggno
efmyhuxckqldtwjzvisbgzigno
efryhuxlkqldtwozvisbpargno
lfmyhuxckqldtwjzvhsbparuno
efmyhzxckqldswjzvisqpargno
efmyhuxrkqldtwjzvisgpargco
efmyhudckqldtwjzyisbkargno
efmyhuacqqldtwjzviabpargno
jfmyhuxckqldtwvzvicbpargno
efmkhuxckqlftejzvisbpargno
nfmyhuxckqldnwjzvisbxargno
efmyhuxckqldtwjvvisjpyrgno
efmyhuxcmxldtwjzvisbpargto
efmyhuxckqldtwqbvpsbpargno
efmyhuxckzldjwjzvisbplrgno
efmywgxckqldtwxzvisbpargno
efmsguxckqldhwjzvisbpargno
nfmyhuxlkqldtwjzvisbgargno
etmyhuxckqldtwjzvqsbptrgno
efmyxuxckqldtfjzvisbyargno
cfmihuxckqldtwjzvisbpargnf
jfzyhuxckqldtwjzviscpargno
efmyhuxckqldtmjzvisbpbzgno
bfmyhuzckqldcwjzvisbpargno
efmyhuxckqldtmjzvmslpargno
efqyvuxckqldtwazvisbpargno
efmecrxckqldtwjzvisbpargno
efmyhuuckqldtwjzvisrpargnt
efmphuxckqldtwjzvisbparmho
ifmyhuxckqldtwjzvismpsrgno
efmyhuookqldywjzvisbpargno
efmyhfxckyldtwjnvisbpargno
efmyhxhckqldtwjzvisqpargno
efryhuxcfqldtwjzvisbparkno
efmyhutckqldpwjzvixbpargno
efmyoukckqldtwjzvisbpargko
efmyhuxckqldtwjzviseparynv
efmyhuxcksldvwjzvisbnargno
efmyhuxckqrdtwlzmisbpargno
efmyhuxcwqldtwjzviqapargno
eymyhuxckqrdtwkzvisbpargno
efmyhuxckqldtwjzpisopargnj
efmyhuxikqldtwjzvirupargno
efmyhuxcuzldtnjzvisbpargno
efmyhxxikqldtwjzvisbpalgno
efmyhuxceqldtwjzvdsbparguo
efmyhuxwkqldtwjmvisbparxno
efmyhuxpkqldtwjzvisfpargfo
efmyfuxckaldtwjzvirbpargno
efmyhuxckqrdtwjzvismprrgno
efmyhuxckqldzwjzvisbpnrgfo
efmyhfuckqldtwjyvisipargno
efmyhuxcpqlqfwjzvisbpargno
efmyyuxckqldtwjzvrsepargno
efmphuxckqlptqjzvisbpargno
efmyhuxnfqldtwjzvisbpmrgno
efmyhuxckqldtwjzkisnpnrgno
mfmyhuxckqldtwjzvisbzarcno
efmyhuxckqldtwlzviszpargwo
efmytuxckqndtwjqvisbpargno
efmyzuxckqldtwjzvisbaargjo
efmihuxckqlutwjzvimbpargno
efmyhuxckqldgwjzvixbparono
tfmyduxckqldtyjzvisbpargno
ejmyhuockqldtwjzvidbpargno
efmyheyckqkdtwjzvisbpargno
efmyhuxckqldtwjzoisbpargfj
efqyhuxcxqldtwxzvisbpargno
jfmyhaxckqldtwjzvisbvargno
hfmyhqxckqldtwjzvisbparvno
efmyhukckqlrtwjzvqsbpargno
efmyhuxckqldvwmzvisbparrno
efoyhuxckqldtwjzvilwpargno
ejmyhuxckqldtwjzxisbprrgno
efmyhuxckqldtsjzvisupdrgno
efzyhjxckqldtwjzvisbpasgno
ebmyhulckqldtwjzvisbpargnr
efmyhuxcjqlntwjzqisbpargno
efmlocxckqldtwjzvisbpargno
efmyhuxckqldtwjzvizkpargnm
ebmyhuxckqldtwjzvlfbpargno
efmyhuxckqldtwjyvisbpjrgnq
afmyhuxckqldtwjzvpsbpargnv
efmyxuxckqwdzwjzvisbpargno
efmyhuxskqlqthjzvisbpargno
efmyhuxckqldtwdzvisbearglo
mfmyhuxckqldtzjzvisbparggo
efmyhuqckqodtwjzvisbpadgno
efmyhuxctqldywjzvisspargno
efmyhuxckqqdtwjnvisbporgno
efmyhixckqldowjzvisbpaagno
efmyhuxckqldtsszvisbpargns
edmyhuxckqpdtwjzrisbpargno
efsyhuxckqldtijzvisbparano
efmyhuxckqxdzwjzviqbpargno
efmyhuxckqldtwjzviqqpsrgno
efmyhuockqlatwjzvisbpargho
efmyhuxckqldtwjzvishkavgno
vfmyhuxckqldtwjzvksbaargno
efmahuxckqudtwbzvisbpargno
ewmyhixckqudtwjzvisbpargno
efmywuxczqldtwjzvisbpargao
efmyhuqjkqldtwyzvisbpargno
efmyhuxekqldtwjzmksbpargno
efmyhuxcoqtdtwjzvinbpargno
ebmyhuxkkqldtwjzvisbdargno
ecmyhnxckqldtwnzvisbpargno
efmyhuxbkqldtwjzvksbpaigno
efayhuxckqidtwjzvisbpavgno
efmrhuxckqldswjzvisbpaugno
efmyhuuckqldtwjyvisipargno
xfmyhuxckqldawjzvosbpargno
efmyhuxckklhtwjzvisbpargnq
efmyhmxcaqldzwjzvisbpargno
efiyhuxcksldtwjzvisbpamgno
zfmyhuzckqldtwjzvisbparhno
efmyhuxckqlvtwjdvisbparsno
efmyhmxckaldtwjzmisbpargno
efmysuxcqoldtwjzvisbpargno
efmyhuxckqldtwjzvisbsargrb
effyhuxckqldtwjzvisbpwfgno
efmyhuxclqmdtwjzxisbpargno
edmohuxckqldtwjziisbpargno
efmyhuxckpldtwjzviubpaegno
efmyhuxcpqldtwjzjimbpargno
ehmyhuxckqldtwjzsisbpargnq
efmyhcxcdqldtwjzvisbqargno
efmjhuxckqldmwjzviybpargno
efeyhzxckqlxtwjzvisbpargno
efmyhuxczqadtwazvisbpargno
efmahuxckqldtwjzvisbpafgnl
efmyouxckqldtwjzvizbpacgno
emmrhuxckqldtwjzvisqpargno
exmyhuxckqlftwjnvisbpargno
efuyhuxckqldrwjzvisbpargnw
efmywuxfkqldtwjztisbpargno
efmyhuxdkqldtwjzvisbpqrzno
eemyhuxckqldrwjzvisbpajgno
efmyiuxckqldtbjzvrsbpargno
eqmyhuxckqldlwjzfisbpargno
efmyhuxckqlitwuzvisbpvrgno
ecoyhuxckqldtwjzvishpargno
efmyhuxckcldtwjzlisbparlno
efmyhsxcknldtwjfvisbpargno
efmyhuxckqldtwjrvosbpargbo
enmehuxckzldtwjzvisbpargno
hfmyhuxckqqdtwjzvisbpawgno
efmyhufckcjdtwjzvisbpargno
efmxhuxckqldthjzvisfpargno
efmyaukckqldtwjsvisbpargno
efmyhukckqldtwpzvisbpmrgno
dfmyhuxckqldtwjzvisbvarmno
afmbhuxckqldtwjzvssbpargno
efmyhuxchqldtwezvisbpargzo
efmphuxckqlxjwjzvisbpargno
efhyxuxckqldtwjzvisbpargko
sfmyhexckqldtwjzvisbqargno
efmghuxckqldtwjzvitbparnno";


        public const string Part1FullRunOutput = "7808";
        public const string Part2FullRunOutput = "efmyhuckqldtwjyvisipargno";
    }
}