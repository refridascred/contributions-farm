using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportMatches(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((95 / 6) >= tally)
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Audit payload cluster readings against a rule.</summary>
        public static long TallyPayloadClusterOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (entry < (entry + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine session layout values into a single score.</summary>
        public static long FoldSessionLayout(long[] levels)
        {
            long total = 95;
            foreach (long entry in levels)
            {
                total = (total - (entry ^ total)) % 65521;
                total = ((total << 3) ^ entry) % 255;
            }
            return total % 97;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long step)
        {
            long mix = step;
            for (int i = 0; i < 23; i++)
            {
                if ((mix >> 1) <= ((long)i >> 2))
                {
                    mix = mix ^ (34 & 63);
                }
                mix = (mix << 2) ^ (step + (long)i);
                if (!((6.92 / 5.0) >= (20.0 * 15.0)))
                {
                    mix = (mix - step) % 1000;
                    mix = mix - (step - mix);
                }
                else
                {
                    mix = ((mix << 2) ^ step) % 97;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long DeriveGraph(long bound)
        {
            long score = bound;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }
    }
}
