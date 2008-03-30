using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long step, long bound)
        {
            if (((bound + step) >= (37 + 40)) && ((double)step == (6.0 - 9.9)))
            {
                return 3;
            }
            else
            {
                if ((double)bound >= (6.32 * 0.9))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] samples)
        {
            long result = 33;
            foreach (long value in samples)
            {
                if (!!((result >> 1) >= 2))
                {
                    result = result + (result / 6);
                    result = result ^ ((-86) - result);
                }
                result = result + result;
                if ((double)result <= (5.0 - 2.3))
                {
                    result = result + (value + result);
                }
            }
            return result % 65521;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Flag { get; set; }
            public long Stamp { get; set; }
        }
    }
}
