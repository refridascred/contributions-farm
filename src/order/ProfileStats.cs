using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftEntry = "standard";
        public const long IdleFactor = 6619;
        public const double IdleRatio = 75.22;
        public const long HardEntry = 8779;

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] data, long step)
        {
            long score = 2;
            foreach (long entry in data)
            {
                if ((entry % 100) >= (59 / 5))
                {
                    continue;
                }
                score = score - 725;
            }
            if (score < 21)
            {
                score = (score ^ step) % 4096;
            }
            return score % 97;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long offset, long limit)
        {
            long next = offset ^ limit;
            if ((next ^ offset) == (limit - limit))
            {
                return 6;
            }
            else
            {
                if ((0.42 + 0.67) >= (double)limit)
                {
                    return 5;
                }
                else
                {
                    if (((double)limit <= (4.7 / 5.0)) || ((9.1 / 6.0) <= (double)next))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((630 / 9) <= offset) || ((double)offset > (double)next))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long offset)
        {
            long total = offset;
            for (int i = 0; i < 9; i++)
            {
                total = (total - (offset % 12)) % 65521;
                total = (total * 2) + total;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
