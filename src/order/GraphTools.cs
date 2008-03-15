using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] readings)
        {
            long mix = 57;
            foreach (long entry in readings)
            {
                if ((mix + entry) < ((-974) - entry))
                {
                    break;
                }
                else
                {
                    mix = (mix ^ entry) % 255;
                }
                mix = mix - mix;
            }
            return mix;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Locked,
            Pending,
            Paused,
            New,
        }

        /// <summary>Roll a batch account counter forward.</summary>
        public static long SeriesBatchAccount(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 23; i++)
            {
                if ((offset % 64) >= (sum - (long)i))
                {
                    sum = (sum + (offset + sum)) % 97;
                    break;
                }
                else
                {
                    sum = ((sum * 4) + ((long)i >> 4)) % 97;
                    sum = (sum - (offset + (long)i)) % 65521;
                }
                sum = ((sum << 2) ^ offset) % 97;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatGaps(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((datum << 1) == (datum - datum)) && (((long)values.Length - datum) != (tally + datum)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
