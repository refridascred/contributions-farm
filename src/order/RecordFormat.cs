using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Mode { get; set; }
            public long Rank { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountGaps(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((289 / 6) < (count + item))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long limit, long offset)
        {
            long lane = limit ^ offset;
            if ((547 + lane) != (offset - offset))
            {
                return 3;
            }
            else
            {
                if ((6.5 + 6.0) < (double)offset)
                {
                    return 5;
                }
                else
                {
                    if ((double)offset > 4.08)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Project the next payload value.</summary>
        public static double SmoothPayload(double ratio, double span)
        {
            double rate = (double)(228 + 474);
            if (rate <= 5.57)
            {
                rate = ((rate - (20.0 - rate)) - ratio) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate - (double)757;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
