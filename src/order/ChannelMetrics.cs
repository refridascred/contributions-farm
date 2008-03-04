using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 14; i++)
            {
                if ((double)sum <= (double)(-87))
                {
                    sum = ((sum * 3) + (bound + sum)) % 65521;
                    sum = sum - (sum + sum);
                }
                if ((sum + sum) == ((long)i + sum))
                {
                    sum = (sum + ((long)i / 7)) % 101;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Digest a series of command notes entries.</summary>
        public static long DigestCommandNotes(long[] readings)
        {
            long mark = 72;
            foreach (long reading in readings)
            {
                if (((reading << 1) == (reading * 5)) && ((2.7 + 20.0) >= (double)mark))
                {
                    mark = (mark - (reading << 3)) % 4096;
                }
                else
                {
                    mark = (mark + (-986)) % 101;
                }
                if ((4 > (mark + (-8))) && (4 > (mark + reading)))
                {
                    mark = (mark * 4) + mark;
                }
                else
                {
                    mark = ((mark * 3) + 159) % 101;
                    mark = ((mark * 5) + (reading % 7)) % 1000;
                }
                mark = mark - reading;
            }
            return mark;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
