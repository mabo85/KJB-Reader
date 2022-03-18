﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KJB_Reader
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void About_Load(object sender, EventArgs e)
        {
            linkLabelMark.Links.Add(0, linkLabelMark.Text.Length, "https://www.youtube.com/channel/UC3oANk5VrakAYDePNtAY4ZA");
            linkLabelMark.LinkClicked += new LinkLabelLinkClickedEventHandler(LinkedLabelClicked);
            
            linkLabelRick.Links.Add(0, linkLabelRick.Text.Length, "https://www.youtube.com/channel/UC_QvKE6YsXMD5mbCafJUBKA");
            linkLabelRick.LinkClicked += new LinkLabelLinkClickedEventHandler(LinkedLabelClicked);

            linkLabelGithub.Links.Add(0, linkLabelGithub.Text.Length, "https://github.com/mabo85");
            linkLabelGithub.LinkClicked += new LinkLabelLinkClickedEventHandler(LinkedLabelClicked);

            //rtbAbout.Rtf = File.ReadAllText("salvation.rtf");
            rtbAbout.Rtf = salvationMessage;

        }

        private void LinkedLabelClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo(e.Link.LinkData as string);
            sInfo.UseShellExecute = true; // (!!!) for NET Core (see: https://stackoverflow.com/questions/21835891/process-starturl-fails)
            Process.Start(sInfo);
        }

        private string salvationMessage = @"{\rtf1\adeflang1025\ansi\ansicpg1252\uc1\adeff0\deff0\stshfdbch0\stshfloch31506\stshfhich31506\stshfbi31506\deflang1031\deflangfe1031\themelang1031\themelangfe0\themelangcs0{\fonttbl{\f0\fbidi \froman\fcharset0\fprq2{\*\panose 00000000000000000000}Times New Roman;}{\f34\fbidi \froman\fcharset0\fprq2{\*\panose 02040503050406030204}Cambria Math;}
{\f37\fbidi \fswiss\fcharset0\fprq2{\*\panose 00000000000000000000}Calibri;}{\flomajor\f31500\fbidi \froman\fcharset0\fprq2{\*\panose 00000000000000000000}Times New Roman;}
{\fdbmajor\f31501\fbidi \froman\fcharset0\fprq2{\*\panose 00000000000000000000}Times New Roman;}{\fhimajor\f31502\fbidi \fswiss\fcharset0\fprq2{\*\panose 00000000000000000000}Calibri Light;}
{\fbimajor\f31503\fbidi \froman\fcharset0\fprq2{\*\panose 00000000000000000000}Times New Roman;}{\flominor\f31504\fbidi \froman\fcharset0\fprq2{\*\panose 00000000000000000000}Times New Roman;}
{\fdbminor\f31505\fbidi \froman\fcharset0\fprq2{\*\panose 00000000000000000000}Times New Roman;}{\fhiminor\f31506\fbidi \fswiss\fcharset0\fprq2{\*\panose 00000000000000000000}Calibri;}
{\fbiminor\f31507\fbidi \froman\fcharset0\fprq2{\*\panose 00000000000000000000}Times New Roman;}{\f43\fbidi \froman\fcharset238\fprq2 Times New Roman CE;}{\f44\fbidi \froman\fcharset204\fprq2 Times New Roman Cyr;}
{\f46\fbidi \froman\fcharset161\fprq2 Times New Roman Greek;}{\f47\fbidi \froman\fcharset162\fprq2 Times New Roman Tur;}{\f48\fbidi \froman\fcharset177\fprq2 Times New Roman (Hebrew);}{\f49\fbidi \froman\fcharset178\fprq2 Times New Roman (Arabic);}
{\f50\fbidi \froman\fcharset186\fprq2 Times New Roman Baltic;}{\f51\fbidi \froman\fcharset163\fprq2 Times New Roman (Vietnamese);}{\f383\fbidi \froman\fcharset238\fprq2 Cambria Math CE;}{\f384\fbidi \froman\fcharset204\fprq2 Cambria Math Cyr;}
{\f386\fbidi \froman\fcharset161\fprq2 Cambria Math Greek;}{\f387\fbidi \froman\fcharset162\fprq2 Cambria Math Tur;}{\f390\fbidi \froman\fcharset186\fprq2 Cambria Math Baltic;}{\f391\fbidi \froman\fcharset163\fprq2 Cambria Math (Vietnamese);}
{\f413\fbidi \fswiss\fcharset238\fprq2 Calibri CE;}{\f414\fbidi \fswiss\fcharset204\fprq2 Calibri Cyr;}{\f416\fbidi \fswiss\fcharset161\fprq2 Calibri Greek;}{\f417\fbidi \fswiss\fcharset162\fprq2 Calibri Tur;}
{\f418\fbidi \fswiss\fcharset177\fprq2 Calibri (Hebrew);}{\f419\fbidi \fswiss\fcharset178\fprq2 Calibri (Arabic);}{\f420\fbidi \fswiss\fcharset186\fprq2 Calibri Baltic;}{\f421\fbidi \fswiss\fcharset163\fprq2 Calibri (Vietnamese);}
{\flomajor\f31508\fbidi \froman\fcharset238\fprq2 Times New Roman CE;}{\flomajor\f31509\fbidi \froman\fcharset204\fprq2 Times New Roman Cyr;}{\flomajor\f31511\fbidi \froman\fcharset161\fprq2 Times New Roman Greek;}
{\flomajor\f31512\fbidi \froman\fcharset162\fprq2 Times New Roman Tur;}{\flomajor\f31513\fbidi \froman\fcharset177\fprq2 Times New Roman (Hebrew);}{\flomajor\f31514\fbidi \froman\fcharset178\fprq2 Times New Roman (Arabic);}
{\flomajor\f31515\fbidi \froman\fcharset186\fprq2 Times New Roman Baltic;}{\flomajor\f31516\fbidi \froman\fcharset163\fprq2 Times New Roman (Vietnamese);}{\fdbmajor\f31518\fbidi \froman\fcharset238\fprq2 Times New Roman CE;}
{\fdbmajor\f31519\fbidi \froman\fcharset204\fprq2 Times New Roman Cyr;}{\fdbmajor\f31521\fbidi \froman\fcharset161\fprq2 Times New Roman Greek;}{\fdbmajor\f31522\fbidi \froman\fcharset162\fprq2 Times New Roman Tur;}
{\fdbmajor\f31523\fbidi \froman\fcharset177\fprq2 Times New Roman (Hebrew);}{\fdbmajor\f31524\fbidi \froman\fcharset178\fprq2 Times New Roman (Arabic);}{\fdbmajor\f31525\fbidi \froman\fcharset186\fprq2 Times New Roman Baltic;}
{\fdbmajor\f31526\fbidi \froman\fcharset163\fprq2 Times New Roman (Vietnamese);}{\fhimajor\f31528\fbidi \fswiss\fcharset238\fprq2 Calibri Light CE;}{\fhimajor\f31529\fbidi \fswiss\fcharset204\fprq2 Calibri Light Cyr;}
{\fhimajor\f31531\fbidi \fswiss\fcharset161\fprq2 Calibri Light Greek;}{\fhimajor\f31532\fbidi \fswiss\fcharset162\fprq2 Calibri Light Tur;}{\fhimajor\f31533\fbidi \fswiss\fcharset177\fprq2 Calibri Light (Hebrew);}
{\fhimajor\f31534\fbidi \fswiss\fcharset178\fprq2 Calibri Light (Arabic);}{\fhimajor\f31535\fbidi \fswiss\fcharset186\fprq2 Calibri Light Baltic;}{\fhimajor\f31536\fbidi \fswiss\fcharset163\fprq2 Calibri Light (Vietnamese);}
{\fbimajor\f31538\fbidi \froman\fcharset238\fprq2 Times New Roman CE;}{\fbimajor\f31539\fbidi \froman\fcharset204\fprq2 Times New Roman Cyr;}{\fbimajor\f31541\fbidi \froman\fcharset161\fprq2 Times New Roman Greek;}
{\fbimajor\f31542\fbidi \froman\fcharset162\fprq2 Times New Roman Tur;}{\fbimajor\f31543\fbidi \froman\fcharset177\fprq2 Times New Roman (Hebrew);}{\fbimajor\f31544\fbidi \froman\fcharset178\fprq2 Times New Roman (Arabic);}
{\fbimajor\f31545\fbidi \froman\fcharset186\fprq2 Times New Roman Baltic;}{\fbimajor\f31546\fbidi \froman\fcharset163\fprq2 Times New Roman (Vietnamese);}{\flominor\f31548\fbidi \froman\fcharset238\fprq2 Times New Roman CE;}
{\flominor\f31549\fbidi \froman\fcharset204\fprq2 Times New Roman Cyr;}{\flominor\f31551\fbidi \froman\fcharset161\fprq2 Times New Roman Greek;}{\flominor\f31552\fbidi \froman\fcharset162\fprq2 Times New Roman Tur;}
{\flominor\f31553\fbidi \froman\fcharset177\fprq2 Times New Roman (Hebrew);}{\flominor\f31554\fbidi \froman\fcharset178\fprq2 Times New Roman (Arabic);}{\flominor\f31555\fbidi \froman\fcharset186\fprq2 Times New Roman Baltic;}
{\flominor\f31556\fbidi \froman\fcharset163\fprq2 Times New Roman (Vietnamese);}{\fdbminor\f31558\fbidi \froman\fcharset238\fprq2 Times New Roman CE;}{\fdbminor\f31559\fbidi \froman\fcharset204\fprq2 Times New Roman Cyr;}
{\fdbminor\f31561\fbidi \froman\fcharset161\fprq2 Times New Roman Greek;}{\fdbminor\f31562\fbidi \froman\fcharset162\fprq2 Times New Roman Tur;}{\fdbminor\f31563\fbidi \froman\fcharset177\fprq2 Times New Roman (Hebrew);}
{\fdbminor\f31564\fbidi \froman\fcharset178\fprq2 Times New Roman (Arabic);}{\fdbminor\f31565\fbidi \froman\fcharset186\fprq2 Times New Roman Baltic;}{\fdbminor\f31566\fbidi \froman\fcharset163\fprq2 Times New Roman (Vietnamese);}
{\fhiminor\f31568\fbidi \fswiss\fcharset238\fprq2 Calibri CE;}{\fhiminor\f31569\fbidi \fswiss\fcharset204\fprq2 Calibri Cyr;}{\fhiminor\f31571\fbidi \fswiss\fcharset161\fprq2 Calibri Greek;}{\fhiminor\f31572\fbidi \fswiss\fcharset162\fprq2 Calibri Tur;}
{\fhiminor\f31573\fbidi \fswiss\fcharset177\fprq2 Calibri (Hebrew);}{\fhiminor\f31574\fbidi \fswiss\fcharset178\fprq2 Calibri (Arabic);}{\fhiminor\f31575\fbidi \fswiss\fcharset186\fprq2 Calibri Baltic;}
{\fhiminor\f31576\fbidi \fswiss\fcharset163\fprq2 Calibri (Vietnamese);}{\fbiminor\f31578\fbidi \froman\fcharset238\fprq2 Times New Roman CE;}{\fbiminor\f31579\fbidi \froman\fcharset204\fprq2 Times New Roman Cyr;}
{\fbiminor\f31581\fbidi \froman\fcharset161\fprq2 Times New Roman Greek;}{\fbiminor\f31582\fbidi \froman\fcharset162\fprq2 Times New Roman Tur;}{\fbiminor\f31583\fbidi \froman\fcharset177\fprq2 Times New Roman (Hebrew);}
{\fbiminor\f31584\fbidi \froman\fcharset178\fprq2 Times New Roman (Arabic);}{\fbiminor\f31585\fbidi \froman\fcharset186\fprq2 Times New Roman Baltic;}{\fbiminor\f31586\fbidi \froman\fcharset163\fprq2 Times New Roman (Vietnamese);}}
{\colortbl;\red0\green0\blue0;\red0\green0\blue255;\red0\green255\blue255;\red0\green255\blue0;\red255\green0\blue255;\red255\green0\blue0;\red255\green255\blue0;\red255\green255\blue255;\red0\green0\blue128;\red0\green128\blue128;\red0\green128\blue0;
\red128\green0\blue128;\red128\green0\blue0;\red128\green128\blue0;\red128\green128\blue128;\red192\green192\blue192;\red0\green0\blue0;\red0\green0\blue0;}{\*\defchp \f31506\fs22\lang1031\langfe1033\langfenp1033 }{\*\defpap 
\ql \li0\ri0\sa160\sl259\slmult1\widctlpar\wrapdefault\aspalpha\aspnum\faauto\adjustright\rin0\lin0\itap0 }\noqfpromote {\stylesheet{\ql \li0\ri0\sa160\sl259\slmult1\widctlpar\wrapdefault\aspalpha\aspnum\faauto\adjustright\rin0\lin0\itap0 \rtlch\fcs1 
\af0\afs22\alang1025 \ltrch\fcs0 \f31506\fs22\lang2057\langfe1033\cgrid\langnp2057\langfenp1033 \snext0 \sqformat \spriority0 Normal;}{\*\cs10 \additive \sunhideused \spriority1 Default Paragraph Font;}{\*
\ts11\tsrowd\trftsWidthB3\trpaddl108\trpaddr108\trpaddfl3\trpaddft3\trpaddfb3\trpaddfr3\trcbpat1\trcfpat1\tblind0\tblindtype3\tsvertalt\tsbrdrt\tsbrdrl\tsbrdrb\tsbrdrr\tsbrdrdgl\tsbrdrdgr\tsbrdrh\tsbrdrv \ql \li0\ri0\sa160\sl259\slmult1
\widctlpar\wrapdefault\aspalpha\aspnum\faauto\adjustright\rin0\lin0\itap0 \rtlch\fcs1 \af31506\afs22\alang1025 \ltrch\fcs0 \f31506\fs22\lang1031\langfe1033\cgrid\langnp1031\langfenp1033 \snext11 \ssemihidden \sunhideused Normal Table;}}
{\*\rsidtbl \rsid20157\rsid4015971\rsid5131297\rsid5187111\rsid6190365\rsid8651129\rsid8939734\rsid10771681\rsid11352557\rsid11433189}{\mmathPr\mmathFont34\mbrkBin0\mbrkBinSub0\msmallFrac0\mdispDef1\mlMargin0\mrMargin0\mdefJc1\mwrapIndent1440\mintLim0
\mnaryLim1}{\info{\author Alfa}{\operator Alfa}{\creatim\yr2022\mo3\dy15\hr11\min38}{\revtim\yr2022\mo3\dy15\hr12\min23}{\version8}{\edmins0}{\nofpages1}{\nofwords138}{\nofchars872}{\*\company alfatraining}{\nofcharsws1008}{\vern79}}
{\*\xmlnstbl {\xmlns1 http://schemas.microsoft.com/office/word/2003/wordml}}\paperw11906\paperh16838\margl1417\margr1417\margt1417\margb1134\gutter0\ltrsect 
\deftab708\widowctrl\ftnbj\aenddoc\hyphhotz425\trackmoves0\trackformatting1\donotembedsysfont1\relyonvml0\donotembedlingdata0\grfdocevents0\validatexml1\showplaceholdtext0\ignoremixedcontent0\saveinvalidxml0
\showxmlerrors1\noxlattoyen\expshrtn\noultrlspc\dntblnsbdb\nospaceforul\formshade\horzdoc\dgmargin\dghspace180\dgvspace180\dghorigin1417\dgvorigin1417\dghshow1\dgvshow1
\jexpand\viewkind1\viewscale100\pgbrdrhead\pgbrdrfoot\splytwnine\ftnlytwnine\htmautsp\nolnhtadjtbl\useltbaln\alntblind\lytcalctblwd\lyttblrtgr\lnbrkrule\nobrkwrptbl\snaptogridincell\allowfieldendsel\wrppunct
\asianbrkrule\rsidroot11433189\newtblstyruls\nogrowautofit\usenormstyforlist\noindnmbrts\felnbrelev\nocxsptable\indrlsweleven\noafcnsttbl\afelev\utinl\hwelev\spltpgpar\notcvasp\notbrkcnstfrctbl\notvatxbx\krnprsnet\cachedcolbal \nouicompat \fet0
{\*\wgrffmtfilter 2450}\nofeaturethrottle1\ilfomacatclnup0\ltrpar \sectd \ltrsect\linex0\headery708\footery708\colsx708\endnhere\sectlinegrid360\sectdefaultcl\sftnbj {\*\pnseclvl1\pnucrm\pnstart1\pnindent720\pnhang {\pntxta .}}{\*\pnseclvl2
\pnucltr\pnstart1\pnindent720\pnhang {\pntxta .}}{\*\pnseclvl3\pndec\pnstart1\pnindent720\pnhang {\pntxta .}}{\*\pnseclvl4\pnlcltr\pnstart1\pnindent720\pnhang {\pntxta )}}{\*\pnseclvl5\pndec\pnstart1\pnindent720\pnhang {\pntxtb (}{\pntxta )}}{\*\pnseclvl6
\pnlcltr\pnstart1\pnindent720\pnhang {\pntxtb (}{\pntxta )}}{\*\pnseclvl7\pnlcrm\pnstart1\pnindent720\pnhang {\pntxtb (}{\pntxta )}}{\*\pnseclvl8\pnlcltr\pnstart1\pnindent720\pnhang {\pntxtb (}{\pntxta )}}{\*\pnseclvl9\pnlcrm\pnstart1\pnindent720\pnhang 
{\pntxtb (}{\pntxta )}}\pard\plain \ltrpar\ql \li0\ri0\sa160\sl259\slmult1\widctlpar\wrapdefault\aspalpha\aspnum\faauto\adjustright\rin0\lin0\itap0\pararsid5131297 \rtlch\fcs1 \af0\afs22\alang1025 \ltrch\fcs0 
\f31506\fs22\lang2057\langfe1033\cgrid\langnp2057\langfenp1033 {\rtlch\fcs1 \af0 \ltrch\fcs0 \fs28\insrsid5131297\charrsid6190365 According to the Bible, there are no righteous people }{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 
\fs20\insrsid5131297\charrsid6190365 (Romans}{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 \fs20\insrsid8651129\charrsid6190365 \~}{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 \fs20\insrsid5131297\charrsid6190365 3:10)}{\rtlch\fcs1 \af0 \ltrch\fcs0 
\fs28\insrsid5131297\charrsid6190365 .  All men are born sinners }{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 \fs20\insrsid5131297\charrsid6190365 (Psalm 51:5; Romans}{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 \fs20\insrsid8651129\charrsid6190365 \~}{\rtlch\fcs1 
\af0\afs16 \ltrch\fcs0 \fs20\insrsid5131297\charrsid6190365 3:23)}{\rtlch\fcs1 \af0 \ltrch\fcs0 \fs28\insrsid5131297\charrsid6190365  who are headed for hell }{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 \fs20\insrsid5131297\charrsid6190365 (Psalm}{\rtlch\fcs1 
\af0\afs16 \ltrch\fcs0 \fs20\insrsid8651129\charrsid6190365 \~}{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 \fs20\insrsid5131297\charrsid6190365 9:17)}{\rtlch\fcs1 \af0 \ltrch\fcs0 \fs28\insrsid5131297\charrsid6190365 
.  We cannot reconcile ourselves to God by any good works }{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 \fs20\insrsid5131297\charrsid6190365 (Isaiah}{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 \fs20\insrsid8651129\charrsid6190365 \~}{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 
\fs20\insrsid5131297\charrsid6190365 64:6; Romans}{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 \fs20\insrsid8651129\charrsid6190365 \~}{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 \fs20\insrsid5131297\charrsid6190365 3:20; Ephesians}{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 
\fs20\insrsid8651129\charrsid6190365 \~}{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 \fs20\insrsid5131297\charrsid6190365 2:8-9)}{\rtlch\fcs1 \af0 \ltrch\fcs0 \fs28\insrsid5131297\charrsid6190365 .
\par God demands a blood payment for sin }{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 \fs20\insrsid5131297\charrsid6190365 (Hebrews}{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 \fs20\insrsid8651129\charrsid6190365 \~}{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 
\fs20\insrsid5131297\charrsid6190365 9:22)}{\rtlch\fcs1 \af0 \ltrch\fcs0 \fs28\insrsid5131297\charrsid6190365 .  God sent his son Jesus Christ, who}{\rtlch\fcs1 \af0 \ltrch\fcs0 \fs28\insrsid8651129\charrsid6190365  }{\rtlch\fcs1 \af0 \ltrch\fcs0 
\fs28\insrsid5131297\charrsid6190365 was God in the flesh }{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 \fs20\insrsid5131297\charrsid6190365 (1}{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 \fs20\insrsid8651129\charrsid6190365 \~}{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 
\fs20\insrsid5131297\charrsid6190365 Timothy}{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 \fs20\insrsid8651129\charrsid6190365 \~}{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 \fs20\insrsid5131297\charrsid6190365 3:16)}{\rtlch\fcs1 \af0 \ltrch\fcs0 
\fs28\insrsid5131297\charrsid6190365 , who lived a sinless life }{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 \fs20\insrsid5131297\charrsid6190365 (Hebrews}{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 \fs20\insrsid8651129\charrsid6190365 \~}{\rtlch\fcs1 \af0\afs16 
\ltrch\fcs0 \fs20\insrsid5131297\charrsid6190365 4:15)}{\rtlch\fcs1 \af0 \ltrch\fcs0 \fs28\insrsid5131297\charrsid6190365  to die in our place for our sins }{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 \fs20\insrsid5131297\charrsid6190365 (Romans}{\rtlch\fcs1 
\af0\afs16 \ltrch\fcs0 \fs20\insrsid8651129\charrsid6190365 \~}{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 \fs20\insrsid5131297\charrsid6190365 5:6,8; 1}{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 \fs20\insrsid8651129\charrsid6190365 \~}{\rtlch\fcs1 \af0\afs16 
\ltrch\fcs0 \fs20\insrsid5131297\charrsid6190365 Peter}{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 \fs20\insrsid8651129\charrsid6190365 \~}{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 \fs20\insrsid5131297\charrsid6190365 3:18)}{\rtlch\fcs1 \af0 \ltrch\fcs0 
\fs28\insrsid5131297\charrsid6190365 .  God laid on Christ the sins of the whole world }{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 \fs20\insrsid5131297\charrsid6190365 (Isaiah}{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 \fs20\insrsid4015971\charrsid6190365 \~}{
\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 \fs20\insrsid5131297\charrsid6190365 53:6; 1}{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 \fs20\insrsid4015971\charrsid6190365 \~}{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 \fs20\insrsid5131297\charrsid6190365 Peter}{\rtlch\fcs1 
\af0\afs16 \ltrch\fcs0 \fs20\insrsid4015971\charrsid6190365 \~}{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 \fs20\insrsid5131297\charrsid6190365 2:24; 1}{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 \fs20\insrsid4015971\charrsid6190365 \~}{\rtlch\fcs1 \af0\afs16 
\ltrch\fcs0 \fs20\insrsid5131297\charrsid6190365 John}{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 \fs20\insrsid4015971\charrsid6190365 \~}{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 \fs20\insrsid5131297\charrsid6190365 2:2)}{\rtlch\fcs1 \af0 \ltrch\fcs0 
\fs28\insrsid5131297\charrsid6190365  so that we might receive his righteousness }{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 \fs20\insrsid5131297\charrsid6190365 (2}{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 \fs20\insrsid4015971\charrsid6190365 \~}{\rtlch\fcs1 
\af0\afs16 \ltrch\fcs0 \fs20\insrsid5131297\charrsid6190365 Corinthians}{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 \fs20\insrsid4015971\charrsid6190365 \~}{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 \fs20\insrsid5131297\charrsid6190365 5:21)}{\rtlch\fcs1 \af0 
\ltrch\fcs0 \fs28\insrsid5131297\charrsid6190365 .  Salvation is a free gift }{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 \fs20\insrsid5131297\charrsid6190365 (Romans}{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 \fs20\insrsid4015971\charrsid6190365 \~}{\rtlch\fcs1 
\af0\afs16 \ltrch\fcs0 \fs20\insrsid5131297\charrsid6190365 5:18,}{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 \fs20\insrsid4015971\charrsid6190365 \~}{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 \fs20\insrsid5131297\charrsid6190365 6:23)}{\rtlch\fcs1 \af0 \ltrch\fcs0 
\fs28\insrsid5131297\charrsid6190365 .
\par All you have to do is receive him }{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 \fs20\insrsid5131297\charrsid6190365 (John}{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 \fs20\insrsid4015971\charrsid6190365 \~}{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 
\fs20\insrsid5131297\charrsid6190365 1:12)}{\rtlch\fcs1 \af0 \ltrch\fcs0 \fs28\insrsid5131297\charrsid6190365  as your Saviour by believing }{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 \fs20\insrsid5131297\charrsid6190365 (Romans}{\rtlch\fcs1 \af0\afs16 
\ltrch\fcs0 \fs20\insrsid4015971\charrsid6190365 \~}{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 \fs20\insrsid5131297\charrsid6190365 4:5)}{\rtlch\fcs1 \af0 \ltrch\fcs0 \fs28\insrsid5131297\charrsid6190365  that God in the flesh }{\rtlch\fcs1 \af0\afs16 
\ltrch\fcs0 \fs20\insrsid5131297\charrsid6190365 (1}{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 \fs20\insrsid4015971\charrsid6190365 \~}{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 \fs20\insrsid5131297\charrsid6190365 Timothy}{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 
\fs20\insrsid4015971\charrsid6190365 \~}{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 \fs20\insrsid5131297\charrsid6190365 3:16)}{\rtlch\fcs1 \af0 \ltrch\fcs0 \fs28\insrsid5131297\charrsid6190365  shed his blood paid for your sins }{\rtlch\fcs1 \af0\afs16 
\ltrch\fcs0 \fs20\insrsid5131297\charrsid6190365 (Ephesians}{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 \fs20\insrsid4015971\charrsid6190365 \~}{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 \fs20\insrsid5131297\charrsid6190365 1:7, Colossians}{\rtlch\fcs1 \af0\afs16 
\ltrch\fcs0 \fs20\insrsid4015971\charrsid6190365 \~}{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 \fs20\insrsid5131297\charrsid6190365 1:14, Hebrews}{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 \fs20\insrsid4015971\charrsid6190365 \~}{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 
\fs20\insrsid5131297\charrsid6190365 1:3)}{\rtlch\fcs1 \af0 \ltrch\fcs0 \fs28\insrsid5131297\charrsid6190365  and that God hath raised him from the dead }{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 \fs20\insrsid5131297\charrsid6190365 (1}{\rtlch\fcs1 \af0\afs16 
\ltrch\fcs0 \fs20\insrsid4015971\charrsid6190365 \~}{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 \fs20\insrsid5131297\charrsid6190365 Corinthians}{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 \fs20\insrsid4015971\charrsid6190365 \~}{\rtlch\fcs1 \af0\afs16 \ltrch\fcs0 
\fs20\insrsid5131297\charrsid6190365 15:1-4)}{\rtlch\fcs1 \af0 \ltrch\fcs0 \fs28\insrsid5131297\charrsid6190365 .
\par Believe that as truth and you shall be saved!}{\rtlch\fcs1 \af0 \ltrch\fcs0 \fs28\insrsid5131297\charrsid6190365 
\par }{\*\themedata 504b030414000600080000002100e9de0fbfff0000001c020000130000005b436f6e74656e745f54797065735d2e786d6cac91cb4ec3301045f748fc83e52d4a
9cb2400825e982c78ec7a27cc0c8992416c9d8b2a755fbf74cd25442a820166c2cd933f79e3be372bd1f07b5c3989ca74aaff2422b24eb1b475da5df374fd9ad
5689811a183c61a50f98f4babebc2837878049899a52a57be670674cb23d8e90721f90a4d2fa3802cb35762680fd800ecd7551dc18eb899138e3c943d7e503b6
b01d583deee5f99824e290b4ba3f364eac4a430883b3c092d4eca8f946c916422ecab927f52ea42b89a1cd59c254f919b0e85e6535d135a8de20f20b8c12c3b0
0c895fcf6720192de6bf3b9e89ecdbd6596cbcdd8eb28e7c365ecc4ec1ff1460f53fe813d3cc7f5b7f020000ffff0300504b030414000600080000002100a5d6
a7e7c0000000360100000b0000005f72656c732f2e72656c73848fcf6ac3300c87ef85bd83d17d51d2c31825762fa590432fa37d00e1287f68221bdb1bebdb4f
c7060abb0884a4eff7a93dfeae8bf9e194e720169aaa06c3e2433fcb68e1763dbf7f82c985a4a725085b787086a37bdbb55fbc50d1a33ccd311ba548b6309512
0f88d94fbc52ae4264d1c910d24a45db3462247fa791715fd71f989e19e0364cd3f51652d73760ae8fa8c9ffb3c330cc9e4fc17faf2ce545046e37944c69e462
a1a82fe353bd90a865aad41ed0b5b8f9d6fd010000ffff0300504b0304140006000800000021006b799616830000008a0000001c0000007468656d652f746865
6d652f7468656d654d616e616765722e786d6c0ccc4d0ac3201040e17da17790d93763bb284562b2cbaebbf600439c1a41c7a0d29fdbd7e5e38337cedf14d59b
4b0d592c9c070d8a65cd2e88b7f07c2ca71ba8da481cc52c6ce1c715e6e97818c9b48d13df49c873517d23d59085adb5dd20d6b52bd521ef2cdd5eb9246a3d8b
4757e8d3f729e245eb2b260a0238fd010000ffff0300504b030414000600080000002100a4d06d8592070000c3200000160000007468656d652f7468656d652f
7468656d65312e786d6cec59cd8b1bc915bf07f23f347d97f5d5ad8fc1f2a24fcfda33b6b164873dd648a5eef2547789aad28cc56208de532e81c026e49085bd
ed21842cecc22eb9e48f31d8249b3f22afaa5bdd5552c99e191c3061463074977eefd5afde7bf5de53d5ddcf5e26d4bbc05c1096f6fcfa9d9aefe174ce16248d
7afeb3d9a4d2f13d2151ba4094a5b8e76fb0f03fbbf7eb5fdd454732c609f6403e1547a8e7c752ae8eaa5531876124eeb0154ee1bb25e30992f0caa3ea82a34b
d09bd06aa3566b55134452df4b51026a1f2f97648efd7b5bb5630aba5329d4c09cf2a9528af7b18bf3ba42888d1852ee5d20daf3618605bb9ce197d2f7281212
bee8f935fde757efddada2a35c88ca03b286dc44ffe572b9c0e2bca1e7e4d1593169108441ab5fe8d7002af771e3f6b8356e15fa3400cde7b0d28c8badb3dd18
0639d600658f0edda3f6a859b7f086fee61ee77ea83e165e8332fdc11e7e321982152dbc0665f8700f1f0eba8391ad5f83327c6b0fdfaef54741dbd2af413125
e9f91eba16b69ac3ed6a0bc892d16327bc1b06937623575ea2201a8ae852532c592a0fc55a825e303e018002522449eac9cd0a2fd11ce277882839e3c43b2151
0c81b7422913305c6bd426b526fc579f403f698fa2238c0c69c50b9888bd21c5c713734e56b2e73f00adbe0179fbf3cf6f5efff8e6f54f6fbefaeacdebbfe773
6b5596dc314a2353ee97effef09f6f7eebfdfb876f7ff9fa8fd9d4bb7861e2dffded77effef1cff7a9871597a678fba7efdffdf8fddb3ffffe5f7ffddaa1bdcf
d199099f91040bef11bef49eb20416e8e08fcff8f524663122a6443f8d044a919ac5a17f2c630bfd68832872e006d8b6e3730ea9c605bcbf7e61119ec67c2d89
43e3c338b180a78cd101e34e2b3c547319669eadd3c83d395f9bb8a7085db8e61ea2d4f2f278bd821c4b5c2a8731b6683ea1289528c229969efa8e9d63ec58dd
178458763d2573ce045b4aef0be20d10719a6446ceac682a858e49027ed9b80882bf2ddb9c3ef7068cba563dc2173612f606a20ef2334c2d33de476b891297ca
194aa869f013246317c9e986cf4ddc5848f0748429f3c60b2c844be63187f51a4e7f0869c6edf653ba496c2497e4dca5f30431662247ec7c18a364e5c24e491a
9bd8cfc5398428f29e30e9829f327b87a877f0034a0fbafb39c196bb3f9c0d9e418635299501a2be5973872fef6366c5ef74439708bb524d9f27568aed73e28c
8ec13ab242fb04638a2ed10263efd9e70e0603b6b26c5e927e10435639c6aec07a80ec5855ef2916d8d3cdcd7e9e3c21c20ad9298ed8013ea79b9dc4b3416982
f821cd8fc0eba6cdc750ea1257003ca6f37313f88840f707f1e234ca63013a8ce03ea8f5498cac02a6de853b5e37dcf2df55f618eccb17168d2bec4b90c1d796
81c46ecabcd7363344ad09ca809921e8325ce916442cf79722aab86ab1b5536e696fdad20dd01d594d4f42d20f76403bbd4ff8bfeb7da0c378fb976f1c9bede3
f43b6ec556b2ba66a77328991ceff4378770bb5dcd90f105f9f49b9a115aa74f30d491fd8c75dbd3dcf634feff7d4f73683fdf763287fa8ddb4ec6870ee3b693
c90f573e4e2753362fd0d7a8038feca0471ffb24074f7d9684d2a9dc507c22f4c18f80df338b090c2a397dd6898b53c0550c8faaccc104162ee248cb789cc9df
10194f63b482d3a1baaf944422571d096fc5041c1ae961a76e85a7ebe4942db2c3ce7a5d1d6c66955520598ed7c2621c0eaa64866eb5cb03bc42bd661be983d6
2d01257b1d12c6643689a683447b3ba88ca48f75c1680e127a651f8545d7c1a2a3d46f5db5c702a8155e811fdc1efc4ceff96100222004e771d09c2f949f3257
6fbdab9df9313d7dc89856044083bd8d80d2d35dc5f5e0f2d4eab250bb82a72d1246b8d924b46574832762f8199c47a71abd0a8debfaba5bbad4a2a74ca1e783
d02a69b43bef6371535f83dc6e6ea0a9992968ea5df6fc5633849099a355cf5fc2a1313c262b881da17e73211ac19dcb5cf26cc3df24b3acb8902324e2cce03a
e964d9202112738f92a4e7abe5176ea0a9ce219a5bbd0109e19325d785b4f2a99103a7db4ec6cb259e4bd3edc688b274f60a193ecb15ce6fb5f8cdc14a92adc1
ddd37871e99dd1357f8a20c4c2765d19704104dc1dd4336b2e085c861589ac8cbf9dc294a75df3364ac750368ee82a46794531937906d7a9bca0a3df0a1b186f
f99ac1a08649f2427816a9026b1ad5aaa645d5c8381cacba1f1652963392665933adaca2aaa63b8b59336ccbc08e2d6f56e40d565b13434e332b7c96ba77536e
779beb76fa84a24a80c10bfb39aaee150a8241ad9ccca2a618efa76195b3f351bb766c17f8016a57291246d66f6dd5eed8ada811cee960f046951fe476a31686
96dbbe525b5adf979b17dbecec05248f1174b96b2a8576255c5b73040dd154f72459da802df252e65b039ebc35273dffcb5ad80f868d7058a975c271256806b5
4a27ec372bfd306cd6c761bd361a345e41619171520fb3bbfa095c60d04d7e63afc7f76eed93ed1dcd9d394baa4cdfca5735717d6b5f6f386eedbd99ba9cf73d
0249e7cb5663d26d7607ad4ab7d99f5482d1a053e90e5b83caa8356c8f26a361d8e94e5ef9de850607fde630688d3b95567d38ac04ad9aa2dfe956da41a3d10f
dafdce38e8bfcadb185879963e725b807935af7bff050000ffff0300504b0304140006000800000021000dd1909fb60000001b010000270000007468656d652f
7468656d652f5f72656c732f7468656d654d616e616765722e786d6c2e72656c73848f4d0ac2301484f78277086f6fd3ba109126dd88d0add40384e4350d363f
2451eced0dae2c082e8761be9969bb979dc9136332de3168aa1a083ae995719ac16db8ec8e4052164e89d93b64b060828e6f37ed1567914b284d262452282e31
98720e274a939cd08a54f980ae38a38f56e422a3a641c8bbd048f7757da0f19b017cc524bd62107bd5001996509affb3fd381a89672f1f165dfe514173d98505
28a2c6cce0239baa4c04ca5bbabac4df000000ffff0300504b01022d0014000600080000002100e9de0fbfff0000001c02000013000000000000000000000000
00000000005b436f6e74656e745f54797065735d2e786d6c504b01022d0014000600080000002100a5d6a7e7c0000000360100000b0000000000000000000000
0000300100005f72656c732f2e72656c73504b01022d00140006000800000021006b799616830000008a0000001c000000000000000000000000001902000074
68656d652f7468656d652f7468656d654d616e616765722e786d6c504b01022d0014000600080000002100a4d06d8592070000c3200000160000000000000000
0000000000d60200007468656d652f7468656d652f7468656d65312e786d6c504b01022d00140006000800000021000dd1909fb60000001b0100002700000000
0000000000000000009c0a00007468656d652f7468656d652f5f72656c732f7468656d654d616e616765722e786d6c2e72656c73504b050600000000050005005d010000970b00000000}
{\*\colorschememapping 3c3f786d6c2076657273696f6e3d22312e302220656e636f64696e673d225554462d3822207374616e64616c6f6e653d22796573223f3e0d0a3c613a636c724d
617020786d6c6e733a613d22687474703a2f2f736368656d61732e6f70656e786d6c666f726d6174732e6f72672f64726177696e676d6c2f323030362f6d6169
6e22206267313d226c743122207478313d22646b3122206267323d226c743222207478323d22646b322220616363656e74313d22616363656e74312220616363
656e74323d22616363656e74322220616363656e74333d22616363656e74332220616363656e74343d22616363656e74342220616363656e74353d22616363656e74352220616363656e74363d22616363656e74362220686c696e6b3d22686c696e6b2220666f6c486c696e6b3d22666f6c486c696e6b222f3e}
{\*\latentstyles\lsdstimax375\lsdlockeddef0\lsdsemihiddendef0\lsdunhideuseddef0\lsdqformatdef0\lsdprioritydef99{\lsdlockedexcept \lsdqformat1 \lsdpriority0 \lsdlocked0 Normal;\lsdqformat1 \lsdpriority9 \lsdlocked0 heading 1;
\lsdsemihidden1 \lsdunhideused1 \lsdqformat1 \lsdpriority9 \lsdlocked0 heading 2;\lsdsemihidden1 \lsdunhideused1 \lsdqformat1 \lsdpriority9 \lsdlocked0 heading 3;\lsdsemihidden1 \lsdunhideused1 \lsdqformat1 \lsdpriority9 \lsdlocked0 heading 4;
\lsdsemihidden1 \lsdunhideused1 \lsdqformat1 \lsdpriority9 \lsdlocked0 heading 5;\lsdsemihidden1 \lsdunhideused1 \lsdqformat1 \lsdpriority9 \lsdlocked0 heading 6;\lsdsemihidden1 \lsdunhideused1 \lsdqformat1 \lsdpriority9 \lsdlocked0 heading 7;
\lsdsemihidden1 \lsdunhideused1 \lsdqformat1 \lsdpriority9 \lsdlocked0 heading 8;\lsdsemihidden1 \lsdunhideused1 \lsdqformat1 \lsdpriority9 \lsdlocked0 heading 9;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 index 1;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 index 2;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 index 3;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 index 4;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 index 5;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 index 6;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 index 7;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 index 8;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 index 9;
\lsdsemihidden1 \lsdunhideused1 \lsdpriority39 \lsdlocked0 toc 1;\lsdsemihidden1 \lsdunhideused1 \lsdpriority39 \lsdlocked0 toc 2;\lsdsemihidden1 \lsdunhideused1 \lsdpriority39 \lsdlocked0 toc 3;
\lsdsemihidden1 \lsdunhideused1 \lsdpriority39 \lsdlocked0 toc 4;\lsdsemihidden1 \lsdunhideused1 \lsdpriority39 \lsdlocked0 toc 5;\lsdsemihidden1 \lsdunhideused1 \lsdpriority39 \lsdlocked0 toc 6;
\lsdsemihidden1 \lsdunhideused1 \lsdpriority39 \lsdlocked0 toc 7;\lsdsemihidden1 \lsdunhideused1 \lsdpriority39 \lsdlocked0 toc 8;\lsdsemihidden1 \lsdunhideused1 \lsdpriority39 \lsdlocked0 toc 9;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Normal Indent;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 footnote text;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 annotation text;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 header;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 footer;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 index heading;\lsdsemihidden1 \lsdunhideused1 \lsdqformat1 \lsdpriority35 \lsdlocked0 caption;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 table of figures;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 envelope address;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 envelope return;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 footnote reference;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 annotation reference;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 line number;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 page number;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 endnote reference;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 endnote text;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 table of authorities;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 macro;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 toa heading;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List Bullet;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List Number;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List 2;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List 3;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List 4;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List 5;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List Bullet 2;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List Bullet 3;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List Bullet 4;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List Bullet 5;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List Number 2;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List Number 3;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List Number 4;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List Number 5;\lsdqformat1 \lsdpriority10 \lsdlocked0 Title;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Closing;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Signature;\lsdsemihidden1 \lsdunhideused1 \lsdpriority1 \lsdlocked0 Default Paragraph Font;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Body Text;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Body Text Indent;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List Continue;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List Continue 2;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List Continue 3;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List Continue 4;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 List Continue 5;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Message Header;\lsdqformat1 \lsdpriority11 \lsdlocked0 Subtitle;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Salutation;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Date;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Body Text First Indent;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Body Text First Indent 2;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Note Heading;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Body Text 2;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Body Text 3;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Body Text Indent 2;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Body Text Indent 3;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Block Text;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Hyperlink;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 FollowedHyperlink;\lsdqformat1 \lsdpriority22 \lsdlocked0 Strong;
\lsdqformat1 \lsdpriority20 \lsdlocked0 Emphasis;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Document Map;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Plain Text;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 E-mail Signature;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 HTML Top of Form;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 HTML Bottom of Form;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Normal (Web);\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 HTML Acronym;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 HTML Address;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 HTML Cite;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 HTML Code;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 HTML Definition;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 HTML Keyboard;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 HTML Preformatted;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 HTML Sample;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 HTML Typewriter;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 HTML Variable;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 annotation subject;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 No List;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Outline List 1;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Outline List 2;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Outline List 3;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Balloon Text;\lsdpriority39 \lsdlocked0 Table Grid;
\lsdsemihidden1 \lsdlocked0 Placeholder Text;\lsdqformat1 \lsdpriority1 \lsdlocked0 No Spacing;\lsdpriority60 \lsdlocked0 Light Shading;\lsdpriority61 \lsdlocked0 Light List;\lsdpriority62 \lsdlocked0 Light Grid;
\lsdpriority63 \lsdlocked0 Medium Shading 1;\lsdpriority64 \lsdlocked0 Medium Shading 2;\lsdpriority65 \lsdlocked0 Medium List 1;\lsdpriority66 \lsdlocked0 Medium List 2;\lsdpriority67 \lsdlocked0 Medium Grid 1;\lsdpriority68 \lsdlocked0 Medium Grid 2;
\lsdpriority69 \lsdlocked0 Medium Grid 3;\lsdpriority70 \lsdlocked0 Dark List;\lsdpriority71 \lsdlocked0 Colorful Shading;\lsdpriority72 \lsdlocked0 Colorful List;\lsdpriority73 \lsdlocked0 Colorful Grid;\lsdpriority60 \lsdlocked0 Light Shading Accent 1;
\lsdpriority61 \lsdlocked0 Light List Accent 1;\lsdpriority62 \lsdlocked0 Light Grid Accent 1;\lsdpriority63 \lsdlocked0 Medium Shading 1 Accent 1;\lsdpriority64 \lsdlocked0 Medium Shading 2 Accent 1;\lsdpriority65 \lsdlocked0 Medium List 1 Accent 1;
\lsdsemihidden1 \lsdlocked0 Revision;\lsdqformat1 \lsdpriority34 \lsdlocked0 List Paragraph;\lsdqformat1 \lsdpriority29 \lsdlocked0 Quote;\lsdqformat1 \lsdpriority30 \lsdlocked0 Intense Quote;\lsdpriority66 \lsdlocked0 Medium List 2 Accent 1;
\lsdpriority67 \lsdlocked0 Medium Grid 1 Accent 1;\lsdpriority68 \lsdlocked0 Medium Grid 2 Accent 1;\lsdpriority69 \lsdlocked0 Medium Grid 3 Accent 1;\lsdpriority70 \lsdlocked0 Dark List Accent 1;\lsdpriority71 \lsdlocked0 Colorful Shading Accent 1;
\lsdpriority72 \lsdlocked0 Colorful List Accent 1;\lsdpriority73 \lsdlocked0 Colorful Grid Accent 1;\lsdpriority60 \lsdlocked0 Light Shading Accent 2;\lsdpriority61 \lsdlocked0 Light List Accent 2;\lsdpriority62 \lsdlocked0 Light Grid Accent 2;
\lsdpriority63 \lsdlocked0 Medium Shading 1 Accent 2;\lsdpriority64 \lsdlocked0 Medium Shading 2 Accent 2;\lsdpriority65 \lsdlocked0 Medium List 1 Accent 2;\lsdpriority66 \lsdlocked0 Medium List 2 Accent 2;
\lsdpriority67 \lsdlocked0 Medium Grid 1 Accent 2;\lsdpriority68 \lsdlocked0 Medium Grid 2 Accent 2;\lsdpriority69 \lsdlocked0 Medium Grid 3 Accent 2;\lsdpriority70 \lsdlocked0 Dark List Accent 2;\lsdpriority71 \lsdlocked0 Colorful Shading Accent 2;
\lsdpriority72 \lsdlocked0 Colorful List Accent 2;\lsdpriority73 \lsdlocked0 Colorful Grid Accent 2;\lsdpriority60 \lsdlocked0 Light Shading Accent 3;\lsdpriority61 \lsdlocked0 Light List Accent 3;\lsdpriority62 \lsdlocked0 Light Grid Accent 3;
\lsdpriority63 \lsdlocked0 Medium Shading 1 Accent 3;\lsdpriority64 \lsdlocked0 Medium Shading 2 Accent 3;\lsdpriority65 \lsdlocked0 Medium List 1 Accent 3;\lsdpriority66 \lsdlocked0 Medium List 2 Accent 3;
\lsdpriority67 \lsdlocked0 Medium Grid 1 Accent 3;\lsdpriority68 \lsdlocked0 Medium Grid 2 Accent 3;\lsdpriority69 \lsdlocked0 Medium Grid 3 Accent 3;\lsdpriority70 \lsdlocked0 Dark List Accent 3;\lsdpriority71 \lsdlocked0 Colorful Shading Accent 3;
\lsdpriority72 \lsdlocked0 Colorful List Accent 3;\lsdpriority73 \lsdlocked0 Colorful Grid Accent 3;\lsdpriority60 \lsdlocked0 Light Shading Accent 4;\lsdpriority61 \lsdlocked0 Light List Accent 4;\lsdpriority62 \lsdlocked0 Light Grid Accent 4;
\lsdpriority63 \lsdlocked0 Medium Shading 1 Accent 4;\lsdpriority64 \lsdlocked0 Medium Shading 2 Accent 4;\lsdpriority65 \lsdlocked0 Medium List 1 Accent 4;\lsdpriority66 \lsdlocked0 Medium List 2 Accent 4;
\lsdpriority67 \lsdlocked0 Medium Grid 1 Accent 4;\lsdpriority68 \lsdlocked0 Medium Grid 2 Accent 4;\lsdpriority69 \lsdlocked0 Medium Grid 3 Accent 4;\lsdpriority70 \lsdlocked0 Dark List Accent 4;\lsdpriority71 \lsdlocked0 Colorful Shading Accent 4;
\lsdpriority72 \lsdlocked0 Colorful List Accent 4;\lsdpriority73 \lsdlocked0 Colorful Grid Accent 4;\lsdpriority60 \lsdlocked0 Light Shading Accent 5;\lsdpriority61 \lsdlocked0 Light List Accent 5;\lsdpriority62 \lsdlocked0 Light Grid Accent 5;
\lsdpriority63 \lsdlocked0 Medium Shading 1 Accent 5;\lsdpriority64 \lsdlocked0 Medium Shading 2 Accent 5;\lsdpriority65 \lsdlocked0 Medium List 1 Accent 5;\lsdpriority66 \lsdlocked0 Medium List 2 Accent 5;
\lsdpriority67 \lsdlocked0 Medium Grid 1 Accent 5;\lsdpriority68 \lsdlocked0 Medium Grid 2 Accent 5;\lsdpriority69 \lsdlocked0 Medium Grid 3 Accent 5;\lsdpriority70 \lsdlocked0 Dark List Accent 5;\lsdpriority71 \lsdlocked0 Colorful Shading Accent 5;
\lsdpriority72 \lsdlocked0 Colorful List Accent 5;\lsdpriority73 \lsdlocked0 Colorful Grid Accent 5;\lsdpriority60 \lsdlocked0 Light Shading Accent 6;\lsdpriority61 \lsdlocked0 Light List Accent 6;\lsdpriority62 \lsdlocked0 Light Grid Accent 6;
\lsdpriority63 \lsdlocked0 Medium Shading 1 Accent 6;\lsdpriority64 \lsdlocked0 Medium Shading 2 Accent 6;\lsdpriority65 \lsdlocked0 Medium List 1 Accent 6;\lsdpriority66 \lsdlocked0 Medium List 2 Accent 6;
\lsdpriority67 \lsdlocked0 Medium Grid 1 Accent 6;\lsdpriority68 \lsdlocked0 Medium Grid 2 Accent 6;\lsdpriority69 \lsdlocked0 Medium Grid 3 Accent 6;\lsdpriority70 \lsdlocked0 Dark List Accent 6;\lsdpriority71 \lsdlocked0 Colorful Shading Accent 6;
\lsdpriority72 \lsdlocked0 Colorful List Accent 6;\lsdpriority73 \lsdlocked0 Colorful Grid Accent 6;\lsdqformat1 \lsdpriority19 \lsdlocked0 Subtle Emphasis;\lsdqformat1 \lsdpriority21 \lsdlocked0 Intense Emphasis;
\lsdqformat1 \lsdpriority31 \lsdlocked0 Subtle Reference;\lsdqformat1 \lsdpriority32 \lsdlocked0 Intense Reference;\lsdqformat1 \lsdpriority33 \lsdlocked0 Book Title;\lsdsemihidden1 \lsdunhideused1 \lsdpriority37 \lsdlocked0 Bibliography;
\lsdsemihidden1 \lsdunhideused1 \lsdqformat1 \lsdpriority39 \lsdlocked0 TOC Heading;\lsdpriority41 \lsdlocked0 Plain Table 1;\lsdpriority42 \lsdlocked0 Plain Table 2;\lsdpriority43 \lsdlocked0 Plain Table 3;\lsdpriority44 \lsdlocked0 Plain Table 4;
\lsdpriority45 \lsdlocked0 Plain Table 5;\lsdpriority40 \lsdlocked0 Grid Table Light;\lsdpriority46 \lsdlocked0 Grid Table 1 Light;\lsdpriority47 \lsdlocked0 Grid Table 2;\lsdpriority48 \lsdlocked0 Grid Table 3;\lsdpriority49 \lsdlocked0 Grid Table 4;
\lsdpriority50 \lsdlocked0 Grid Table 5 Dark;\lsdpriority51 \lsdlocked0 Grid Table 6 Colorful;\lsdpriority52 \lsdlocked0 Grid Table 7 Colorful;\lsdpriority46 \lsdlocked0 Grid Table 1 Light Accent 1;\lsdpriority47 \lsdlocked0 Grid Table 2 Accent 1;
\lsdpriority48 \lsdlocked0 Grid Table 3 Accent 1;\lsdpriority49 \lsdlocked0 Grid Table 4 Accent 1;\lsdpriority50 \lsdlocked0 Grid Table 5 Dark Accent 1;\lsdpriority51 \lsdlocked0 Grid Table 6 Colorful Accent 1;
\lsdpriority52 \lsdlocked0 Grid Table 7 Colorful Accent 1;\lsdpriority46 \lsdlocked0 Grid Table 1 Light Accent 2;\lsdpriority47 \lsdlocked0 Grid Table 2 Accent 2;\lsdpriority48 \lsdlocked0 Grid Table 3 Accent 2;
\lsdpriority49 \lsdlocked0 Grid Table 4 Accent 2;\lsdpriority50 \lsdlocked0 Grid Table 5 Dark Accent 2;\lsdpriority51 \lsdlocked0 Grid Table 6 Colorful Accent 2;\lsdpriority52 \lsdlocked0 Grid Table 7 Colorful Accent 2;
\lsdpriority46 \lsdlocked0 Grid Table 1 Light Accent 3;\lsdpriority47 \lsdlocked0 Grid Table 2 Accent 3;\lsdpriority48 \lsdlocked0 Grid Table 3 Accent 3;\lsdpriority49 \lsdlocked0 Grid Table 4 Accent 3;
\lsdpriority50 \lsdlocked0 Grid Table 5 Dark Accent 3;\lsdpriority51 \lsdlocked0 Grid Table 6 Colorful Accent 3;\lsdpriority52 \lsdlocked0 Grid Table 7 Colorful Accent 3;\lsdpriority46 \lsdlocked0 Grid Table 1 Light Accent 4;
\lsdpriority47 \lsdlocked0 Grid Table 2 Accent 4;\lsdpriority48 \lsdlocked0 Grid Table 3 Accent 4;\lsdpriority49 \lsdlocked0 Grid Table 4 Accent 4;\lsdpriority50 \lsdlocked0 Grid Table 5 Dark Accent 4;
\lsdpriority51 \lsdlocked0 Grid Table 6 Colorful Accent 4;\lsdpriority52 \lsdlocked0 Grid Table 7 Colorful Accent 4;\lsdpriority46 \lsdlocked0 Grid Table 1 Light Accent 5;\lsdpriority47 \lsdlocked0 Grid Table 2 Accent 5;
\lsdpriority48 \lsdlocked0 Grid Table 3 Accent 5;\lsdpriority49 \lsdlocked0 Grid Table 4 Accent 5;\lsdpriority50 \lsdlocked0 Grid Table 5 Dark Accent 5;\lsdpriority51 \lsdlocked0 Grid Table 6 Colorful Accent 5;
\lsdpriority52 \lsdlocked0 Grid Table 7 Colorful Accent 5;\lsdpriority46 \lsdlocked0 Grid Table 1 Light Accent 6;\lsdpriority47 \lsdlocked0 Grid Table 2 Accent 6;\lsdpriority48 \lsdlocked0 Grid Table 3 Accent 6;
\lsdpriority49 \lsdlocked0 Grid Table 4 Accent 6;\lsdpriority50 \lsdlocked0 Grid Table 5 Dark Accent 6;\lsdpriority51 \lsdlocked0 Grid Table 6 Colorful Accent 6;\lsdpriority52 \lsdlocked0 Grid Table 7 Colorful Accent 6;
\lsdpriority46 \lsdlocked0 List Table 1 Light;\lsdpriority47 \lsdlocked0 List Table 2;\lsdpriority48 \lsdlocked0 List Table 3;\lsdpriority49 \lsdlocked0 List Table 4;\lsdpriority50 \lsdlocked0 List Table 5 Dark;
\lsdpriority51 \lsdlocked0 List Table 6 Colorful;\lsdpriority52 \lsdlocked0 List Table 7 Colorful;\lsdpriority46 \lsdlocked0 List Table 1 Light Accent 1;\lsdpriority47 \lsdlocked0 List Table 2 Accent 1;\lsdpriority48 \lsdlocked0 List Table 3 Accent 1;
\lsdpriority49 \lsdlocked0 List Table 4 Accent 1;\lsdpriority50 \lsdlocked0 List Table 5 Dark Accent 1;\lsdpriority51 \lsdlocked0 List Table 6 Colorful Accent 1;\lsdpriority52 \lsdlocked0 List Table 7 Colorful Accent 1;
\lsdpriority46 \lsdlocked0 List Table 1 Light Accent 2;\lsdpriority47 \lsdlocked0 List Table 2 Accent 2;\lsdpriority48 \lsdlocked0 List Table 3 Accent 2;\lsdpriority49 \lsdlocked0 List Table 4 Accent 2;
\lsdpriority50 \lsdlocked0 List Table 5 Dark Accent 2;\lsdpriority51 \lsdlocked0 List Table 6 Colorful Accent 2;\lsdpriority52 \lsdlocked0 List Table 7 Colorful Accent 2;\lsdpriority46 \lsdlocked0 List Table 1 Light Accent 3;
\lsdpriority47 \lsdlocked0 List Table 2 Accent 3;\lsdpriority48 \lsdlocked0 List Table 3 Accent 3;\lsdpriority49 \lsdlocked0 List Table 4 Accent 3;\lsdpriority50 \lsdlocked0 List Table 5 Dark Accent 3;
\lsdpriority51 \lsdlocked0 List Table 6 Colorful Accent 3;\lsdpriority52 \lsdlocked0 List Table 7 Colorful Accent 3;\lsdpriority46 \lsdlocked0 List Table 1 Light Accent 4;\lsdpriority47 \lsdlocked0 List Table 2 Accent 4;
\lsdpriority48 \lsdlocked0 List Table 3 Accent 4;\lsdpriority49 \lsdlocked0 List Table 4 Accent 4;\lsdpriority50 \lsdlocked0 List Table 5 Dark Accent 4;\lsdpriority51 \lsdlocked0 List Table 6 Colorful Accent 4;
\lsdpriority52 \lsdlocked0 List Table 7 Colorful Accent 4;\lsdpriority46 \lsdlocked0 List Table 1 Light Accent 5;\lsdpriority47 \lsdlocked0 List Table 2 Accent 5;\lsdpriority48 \lsdlocked0 List Table 3 Accent 5;
\lsdpriority49 \lsdlocked0 List Table 4 Accent 5;\lsdpriority50 \lsdlocked0 List Table 5 Dark Accent 5;\lsdpriority51 \lsdlocked0 List Table 6 Colorful Accent 5;\lsdpriority52 \lsdlocked0 List Table 7 Colorful Accent 5;
\lsdpriority46 \lsdlocked0 List Table 1 Light Accent 6;\lsdpriority47 \lsdlocked0 List Table 2 Accent 6;\lsdpriority48 \lsdlocked0 List Table 3 Accent 6;\lsdpriority49 \lsdlocked0 List Table 4 Accent 6;
\lsdpriority50 \lsdlocked0 List Table 5 Dark Accent 6;\lsdpriority51 \lsdlocked0 List Table 6 Colorful Accent 6;\lsdpriority52 \lsdlocked0 List Table 7 Colorful Accent 6;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Mention;
\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Smart Hyperlink;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Hashtag;\lsdsemihidden1 \lsdunhideused1 \lsdlocked0 Unresolved Mention;}}{\*\datastore 010500000200000018000000
4d73786d6c322e534158584d4c5265616465722e362e30000000000000000000000e0000
d0cf11e0a1b11ae1000000000000000000000000000000003e000300feff0900060000000000000000000000010000000100000000000000001000000200000001000000feffffff0000000000000000ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff
ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff
ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff
ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff
fffffffffffffffffdffffff04000000feffffff05000000fefffffffeffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff
ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff
ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff
ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff
ffffffffffffffffffffffffffffffff52006f006f007400200045006e00740072007900000000000000000000000000000000000000000000000000000000000000000000000000000000000000000016000500ffffffffffffffff010000000c6ad98892f1d411a65f0040963251e50000000000000000000000005089
30205f38d8010300000080020000000000004d0073006f004400610074006100530074006f0072006500000000000000000000000000000000000000000000000000000000000000000000000000000000001a000101ffffffffffffffff020000000000000000000000000000000000000000000000508930205f38d801
508930205f38d801000000000000000000000000d500d7005000d3004900c6004c00db005600d4004f00c2004a004400d300c000d200c2003400da00d600c0003d003d000000000000000000000000000000000032000101ffffffffffffffff030000000000000000000000000000000000000000000000508930205f38
d801508930205f38d8010000000000000000000000004900740065006d0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000a000201ffffffff04000000ffffffff000000000000000000000000000000000000000000000000
00000000000000000000000000000000f100000000000000010000000200000003000000feffffff0500000006000000070000000800000009000000feffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff
ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff
ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff
ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff
ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff3c623a536f757263657320786d6c6e733a623d22687474703a2f2f736368656d61732e6f70656e786d6c666f726d6174732e6f72672f6f6666696365446f63756d656e742f323030362f6269626c696f6772617068792220786d6c6e733d
22687474703a2f2f736368656d61732e6f70656e786d6c666f726d6174732e6f72672f6f6666696365446f63756d656e742f323030362f6269626c696f677261706879222053656c65637465645374796c653d225c415041536978746845646974696f6e4f66666963654f6e6c696e652e78736c22205374796c654e616d
653d22415041222056657273696f6e3d2236222f3e0000000000000000000000000000003c3f786d6c2076657273696f6e3d22312e302220656e636f64696e673d225554462d3822207374616e64616c6f6e653d226e6f223f3e0d0a3c64733a6461746173746f72654974656d2064733a6974656d49443d227b32324633
373344372d464236322d343335372d413232342d3343453043413237424144417d2220786d6c6e733a64733d22687474703a2f2f736368656d61732e6f70656e786d6c666f726d6174732e6f72672f6f6666696365446f63756d656e742f323030362f637573746f6d586d6c223e3c64733a736368656d61526566733e3c
64733a736368656d615265662064733a7572693d22687474703a2f2f736368656d61732e6f70656e500072006f007000650072007400690065007300000000000000000000000000000000000000000000000000000000000000000000000000000000000000000016000200ffffffffffffffffffffffff000000000000
0000000000000000000000000000000000000000000000000000000000000400000055010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000ffffffffffffffffffffffff00000000
00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000ffffffffffffffffffffffff0000
000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000ffffffffffffffffffffffff
000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000786d6c666f726d6174732e6f72672f6f6666696365446f63756d656e742f323030362f6269626c696f677261706879222f3e3c2f64733a736368656d61526566733e3c2f64733a6461746173746f
72654974656d3e0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000
000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000
000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000
00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000105000000000000}}";
    }
}
