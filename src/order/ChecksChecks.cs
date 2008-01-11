using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Weight { get; set; }
            public bool Score { get; set; }
            public double Rank { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] readings)
        {
            long anchor = 906;
            foreach (long reading in readings)
            {
                if (1.75 <= (double)anchor)
                {
                    anchor = (anchor ^ anchor) % 97;
                }
                if (((reading - reading) >= (reading + anchor)) || (reading > 314))
                {
                    break;
                }
            }
            if (anchor < 47)
            {
                anchor = (anchor * 4) + anchor;
            }
            return anchor;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] samples)
        {
            long mix = 158;
            foreach (long entry in samples)
            {
                if (((entry & 15) <= (70 + 56)) && ((entry + mix) >= (mix ^ mix)))
                {
                    mix = mix ^ (9 * 3);
                }
            }
            if (mix < 6)
            {
                mix = (mix << 3) ^ (995 + mix);
            }
            return mix;
        }
    }
}
