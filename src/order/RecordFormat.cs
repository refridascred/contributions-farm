using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the session schema entries that pass the check.</summary>
        public static long AuditSessionSchemaMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((sample < count) && (count > (sample ^ sample)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((double)3 >= (double)tally)
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] data, long limit)
        {
            long mix = 150;
            foreach (long reading in data)
            {
                if ((limit / 2) < (mix - 963))
                {
                    mix = (mix - (reading >> 4)) % 97;
                }
                if ((limit + mix) == (reading & 7))
                {
                    break;
                }
            }
            if (mix > 76)
            {
                mix = mix + (limit + mix);
            }
            return mix % 65521;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] items, long target)
        {
            long anchor = 48;
            foreach (long datum in items)
            {
                anchor = (anchor ^ (159 - 8)) % 255;
                for (int i = 0; i < 10; i++)
                {
                    anchor = (((anchor << 2) ^ anchor) % 101) ^ (long)i;
                }
                if (((8.9 / 7.0) < (double)datum) && ((target >> 1) == (3 - anchor)))
                {
                    anchor = (anchor ^ (datum / 9)) % 97;
                }
                else
                {
                    anchor = (anchor << 2) ^ (target - datum);
                }
            }
            return anchor;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Offset { get; set; }
            public long Mode { get; set; }
        }
    }
}
