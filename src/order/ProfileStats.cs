using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long IterateRecord(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum << 2) ^ sum) % 1000;
                sum = sum + (sum << 2);
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double SmoothGraph(double gain, double span)
        {
            double rate = (double)(986 - 839);
            if (rate > (span + gain))
            {
                rate = rate + (double)3;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (double)7) + (double)(long)i;
            }
            return rate - 9.07;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (tally <= (tally / 2))
                {
                    tally = ((tally + 1) ^ sample) - floor;
                }
            }
            return tally;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorMatches(long[] levels, long target)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((((cell + 948) < cell) && ((hits << 3) > (26 / 5))) || (((8.66 - 8.6) < (double)hits) || ((target % 24) < (-104))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
