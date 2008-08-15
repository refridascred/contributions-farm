using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public double Stamp { get; set; }
            public bool Offset { get; set; }
            public long Label { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsBounds(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank batch record input into a small class.</summary>
        public static long GradeBatchRecord(long target, long origin)
        {
            if ((49 % 100) >= target)
            {
                return 6;
            }
            else
            {
                if ((target ^ (-32)) >= (target + 73))
                {
                    return 3;
                }
                else
                {
                    if (target > origin)
                    {
                        return 8;
                    }
                    else
                    {
                        if (target > (target + origin))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
