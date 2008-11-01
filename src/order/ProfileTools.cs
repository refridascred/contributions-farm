using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long origin)
        {
            long result = origin;
            for (int i = 0; i < 20; i++)
            {
                if (!((double)result >= (1.0 - 3.7)))
                {
                    result = (result << 2) ^ result;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Combine context metric values into a single score.</summary>
        public static long TallyContextMetric(long[] series)
        {
            long anchor = 876;
            foreach (long reading in series)
            {
                anchor = (anchor - (reading * 3)) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Rank { get; set; }
            public string Count { get; set; } = "";
            public bool Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Classify a graph editor pair into a bucket.</summary>
        public static long BucketGraphEditor(long step, long step2)
        {
            if (step2 > step)
            {
                return 7;
            }
            else
            {
                if (!((step + step2) != (498 + step2)))
                {
                    return 8;
                }
                else
                {
                    if ((step >> 2) != (step2 * 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
