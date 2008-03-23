using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadMatches(long[] data, long target)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (((entry < (entry + 368)) && ((seen % 97) != (target + entry))) || !((long)data.Length < seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepLayout = 8701;
        public const string MinSize = "legacy-1";
        public const long HardLayout = 7613;
        public const double MaxScore = 63.82;

        /// <summary>Grade a batch order value against two limits.</summary>
        public static long ClassifyBatchOrder(long offset, long seed)
        {
            if (((double)seed != (9.16 + 6.2)) && ((seed ^ offset) <= offset))
            {
                return 3;
            }
            else
            {
                if (1.4 <= (double)seed)
                {
                    return 5;
                }
                else
                {
                    if (((double)seed > (double)offset) && (offset < (offset + seed)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset * 3) < (seed % 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
