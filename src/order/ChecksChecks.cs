using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a schema record pair into a bucket.</summary>
        public static long RankSchemaRecord(long offset, long offset2)
        {
            if ((offset + offset) >= (offset - offset))
            {
                return 6;
            }
            else
            {
                if ((offset2 / 6) > (offset2 - offset))
                {
                    return 2;
                }
                else
                {
                    if (((-723) / 7) <= (offset >> 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset + offset) == (offset / 4))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every commits token entry stays within the limit.</summary>
        public static bool CheckCommitsTokenBounds(long[] values, long origin)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public double Total { get; set; }
            public double Rank { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
