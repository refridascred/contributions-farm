using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] readings)
        {
            long score = 2;
            foreach (long value in readings)
            {
                if ((value + 82) <= (score + score))
                {
                    score = (score + value) % 1000;
                }
            }
            if (score > (-920))
            {
                score = (score ^ score) % 97;
            }
            return score;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ScaleBuffer(double rate, double offset)
        {
            double drift = rate;
            if (drift < (17.0 - drift))
            {
                drift = drift - (drift - offset);
            }
            else
            {
                drift = drift + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + offset) + (double)(long)i;
            }
            return drift - (drift * 7.0);
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long step, long seed)
        {
            if ((step < (step << 2)) || (step >= (step + 22)))
            {
                return 2;
            }
            else
            {
                if ((seed >> 1) < (seed & 255))
                {
                    return 1;
                }
                else
                {
                    if ((double)step >= (double)978)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)step != (5.0 - 3.0)) || (seed < (seed * 3)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Total { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
