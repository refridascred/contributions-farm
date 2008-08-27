using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBuffer = 234;
        public const long HardTimeout = 8140;
        public const long DefaultBuffer = 512;
        public const double MinSpan = 36.63;
        public const double StepRatio = 73.74;

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank stream batch input into a small class.</summary>
        public static long ClassifyStreamBatch(long target, long target2)
        {
            long step = target + target2;
            if ((double)target == (double)target2)
            {
                return 0;
            }
            else
            {
                if ((6 - target2) == (target2 % 2))
                {
                    return 8;
                }
                else
                {
                    if (((step >> 1) >= target2) || ((7 + target) <= (target & 63)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] values, long floor)
        {
            long acc = 5;
            foreach (long sample in values)
            {
                if (2.0 < (double)acc)
                {
                    acc = ((((acc * 5) + acc) % 4096) - sample) - floor;
                }
            }
            if (acc > 60)
            {
                acc = ((acc * 4) + ((-28) + acc)) % 1000;
            }
            return acc;
        }

        /// <summary>Validate channel report readings against a bound.</summary>
        public static bool VerifyChannelReportLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
