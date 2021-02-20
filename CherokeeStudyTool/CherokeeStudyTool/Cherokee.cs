using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace CherokeeStudyTool
{
    public class Cherokee
    {
        public string English { get; set; }
        public string Phonetic { get; set; }

        public string Syllabary { get; set; }

        public override string ToString()
        {
            return "English: " + English + "   Phonetic: " + Phonetic + "    Syllabary: " + Syllabary;
        }

        public static IEnumerable<Image> images
        {
            get
            {
                return new Image[]
                {
                    Properties.Resources.a,Properties.Resources.e,Properties.Resources.i,Properties.Resources.o,Properties.Resources.u,Properties.Resources.v,
                    Properties.Resources.ga,Properties.Resources.ka,Properties.Resources.ge,Properties.Resources.gi,Properties.Resources.go,Properties.Resources.gu,Properties.Resources.gv,
                    Properties.Resources.ha,Properties.Resources.he,Properties.Resources.hi,Properties.Resources.ho,Properties.Resources.hu,Properties.Resources.hv,
                    Properties.Resources.la,Properties.Resources.le,Properties.Resources.li,Properties.Resources.lo,Properties.Resources.lu,Properties.Resources.lv,
                    Properties.Resources.ma,Properties.Resources.me,Properties.Resources.mi,Properties.Resources.mo,Properties.Resources.mu,Properties.Resources.mv,
                    Properties.Resources.na,Properties.Resources.hna,Properties.Resources.nah,Properties.Resources.ne,Properties.Resources.ni,Properties.Resources.no,Properties.Resources.nu,Properties.Resources.nv,
                    Properties.Resources.qua,Properties.Resources.que,Properties.Resources.qui,Properties.Resources.quo,Properties.Resources.quu,Properties.Resources.quv,
                    Properties.Resources.s,Properties.Resources.sa,Properties.Resources.se,Properties.Resources.si,Properties.Resources.so,Properties.Resources.su,Properties.Resources.sv,
                    Properties.Resources.da,Properties.Resources.ta,Properties.Resources.de,Properties.Resources.te,Properties.Resources.di,Properties.Resources.ti,Properties.Resources._do,Properties.Resources.du,Properties.Resources.dv,
                    Properties.Resources.dla,Properties.Resources.tla,Properties.Resources.tle,Properties.Resources.tli,Properties.Resources.tlo,Properties.Resources.tlu,Properties.Resources.tlv,
                    Properties.Resources.tsa,Properties.Resources.tse,Properties.Resources.tsi,Properties.Resources.tso,Properties.Resources.tsu,Properties.Resources.tsv,
                    Properties.Resources.wa,Properties.Resources.we,Properties.Resources.wi,Properties.Resources.wo,Properties.Resources.wu,Properties.Resources.wv,
                    Properties.Resources.ya,Properties.Resources.ye,Properties.Resources.yi,Properties.Resources.yo,Properties.Resources.yu,Properties.Resources.yv
                };
            }
        }
    }
}