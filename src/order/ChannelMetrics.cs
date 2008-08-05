using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of editor batches readings.</summary>
        public static long WeighEditorBatches(long[] data)
        {
            long total = 157;
            foreach (long cell in data)
            {
                if ((double)total == (6.0 / 3.0))
                {
                    total = ((total * 5) + (cell + 0)) % 97;
                }
            }
            if (total < 7)
            {
                total = (total * 3) + ((-999) % 8);
            }
            return total % 1000;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long BucketSupport(long offset, long bound)
        {
            if (((offset + offset) < (bound + bound)) && ((bound + offset) <= bound))
            {
                return 8;
            }
            else
            {
                if (((bound >> 1) == (offset - offset)) || ((949 + bound) < (916 - offset)))
                {
                    return 5;
                }
                else
                {
                    if ((bound - 7) <= (3 % 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound >= (73 - bound)) && ((offset + bound) <= offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Idle,
            Closed,
            Draft,
        }
    }
}
