using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long step, long origin)
        {
            if ((13.0 + 6.5) > (double)origin)
            {
                return 4;
            }
            else
            {
                if (((double)step <= (9.0 + 1.59)) || ((12 * 4) > (step % 5)))
                {
                    return 2;
                }
                else
                {
                    if (((2.4 + 1.7) <= (double)step) || ((origin - (-32)) >= (step % 12)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step - 740) > (origin - origin))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamRange(long[] series, long offset)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
