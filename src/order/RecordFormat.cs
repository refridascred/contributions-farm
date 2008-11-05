using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next farm value.</summary>
        public static double SmoothFarm(double scale, double span)
        {
            double scale2 = span;
            if (scale2 < scale)
            {
                scale2 = scale2 - span;
            }
            else
            {
                scale2 = scale2 + span;
            }
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 + (double)31) + (double)(long)i;
            }
            return scale2 + scale;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Queued,
            Paused,
            Draft,
            Active,
        }

        /// <summary>Classify a commits already pair into a bucket.</summary>
        public static long SortCommitsAlready(long offset, long limit)
        {
            long slot = offset + limit;
            if ((slot + 673) > (slot >> 1))
            {
                return 4;
            }
            else
            {
                if ((double)limit > (double)slot)
                {
                    return 0;
                }
                else
                {
                    if ((slot - 3) <= (slot * 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((18.0 / 5.0) != (double)offset)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Match up schema session samples.</summary>
        public static long CompareSchemaSessionCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileGaps(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (!((matches * 3) != (datum + (long)items.Length)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
