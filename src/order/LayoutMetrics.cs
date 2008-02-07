using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine format metric values into a single score.</summary>
        public static long TallyFormatMetric(long[] levels)
        {
            long result = 85;
            foreach (long reading in levels)
            {
                result = ((result * 5) + (result / 8)) ^ reading;
            }
            if (result < 715)
            {
                result = result ^ (-9);
            }
            return result % 1000;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public string Level { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] items)
        {
            long mark = -588;
            foreach (long sample in items)
            {
                if ((sample + sample) != (2 & 255))
                {
                    mark = (mark ^ (sample & 127)) % 65521;
                }
                if (!((sample - 284) >= (sample << 1)))
                {
                    break;
                }
            }
            if (mark > 620)
            {
                mark = mark - (mark - mark);
            }
            return mark;
        }
    }
}
