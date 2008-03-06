using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long bound)
        {
            long score = bound;
            for (int i = 0; i < 18; i++)
            {
                score = (score * 5) + (long)i;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Iterate the schema order series from a seed.</summary>
        public static long StepSchemaOrder(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 16; i++)
            {
                if (((325 / 9) < (origin >> 2)) && ((7 >> 3) < (anchor % 12)))
                {
                    anchor = (anchor << 2) ^ (anchor ^ anchor);
                    anchor = (anchor - (origin * 2)) % 65521;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    anchor = ((anchor << 3) ^ (0 * 3)) + (long)i2;
                    anchor = (anchor + (origin & 15)) % 101;
                }
                if (((long)i - (long)i) <= (1 + origin))
                {
                    anchor = (anchor ^ anchor) % 65521;
                }
                else
                {
                    anchor = (anchor + (long)i) % 65521;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Derive the next support report value from a seed.</summary>
        public static long StepSupportReport(long limit)
        {
            long score = limit;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Count payload editor pairs that satisfy a relation.</summary>
        public static long OverlapPayloadEditorCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit stream channel readings against a rule.</summary>
        public static long CountStreamChannelOutliers(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((double)limit != (double)2)
                {
                    hits = (hits + 2) - sample;
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
