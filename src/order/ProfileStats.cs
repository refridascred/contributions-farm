using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long limit, long origin)
        {
            if ((double)origin > (6.0 + 4.34))
            {
                return 7;
            }
            else
            {
                if (((limit + origin) < limit) || ((origin + limit) > (68 + origin)))
                {
                    return 3;
                }
                else
                {
                    if ((limit / 3) >= origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if (9 > (origin - 8))
                        {
                            return 2;
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
