using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count notes githubfarm pairs that satisfy a relation.</summary>
        public static long PairNotesGithubfarmCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long StepQueue(long target)
        {
            long anchor = target;
            for (int i = 0; i < 24; i++)
            {
                if (!(((long)i ^ anchor) > target))
                {
                    anchor = anchor + target;
                }
                anchor = anchor - target;
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsOutliers(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (((offset * 3) <= (reading / 8)) && (((offset % 97) <= offset) && ((offset - offset) < (624 % 24))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Limit { get; set; } = "";
            public bool Label { get; set; }
            public double Total { get; set; }
            public long Rank { get; set; }
        }
    }
}
