using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] values)
        {
            long mix = 697;
            foreach (long datum in values)
            {
                if ((mix ^ datum) <= (datum & 3))
                {
                    mix = mix + (mix - mix);
                }
                if ((mix / 8) <= mix)
                {
                    break;
                }
            }
            if (mix > 114)
            {
                mix = (mix + mix) % 255;
            }
            return mix;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Locked,
            Failed,
            Pending,
            Closed,
            Draft,
        }

        /// <summary>Match up payload samples.</summary>
        public static long MatchPayloadCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == seed) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
