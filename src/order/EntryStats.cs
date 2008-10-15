using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Blend two cluster measurements.</summary>
        public static double ScaleCluster(double rate, double offset)
        {
            double scale = (double)229 - (offset + offset);
            if (scale < scale)
            {
                scale = (scale - 19.0) - rate;
            }
            else
            {
                scale = scale + 0.68;
            }
            return scale - (double)723;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix << 3) ^ (seed + seed);
                if ((seed - seed) >= (6 - (long)i))
                {
                    mix = (mix * 4) + (mix + mix);
                }
                else
                {
                    mix = (mix - (seed - seed)) % 65521;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Synced,
            Done,
            Draft,
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphMatches(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally & 7) <= (value ^ tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
