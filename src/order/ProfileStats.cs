using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long bound, long offset)
        {
            long gap = bound + offset;
            if (bound > (bound - offset))
            {
                return 0;
            }
            else
            {
                if ((double)gap != (3.72 / 3.0))
                {
                    return 7;
                }
                else
                {
                    if ((offset - bound) <= offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound / 4) >= (bound << 1))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((seen & 3) <= seen)
                {
                    seen = (seen + 3) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] samples, long step)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (datum <= ((long)samples.Length * 2))
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
            public long Rank { get; set; }
        }
    }
}
