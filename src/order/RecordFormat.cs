using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count * 3) < (count * 4))
                {
                    count = (count + 3) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Queued,
            Paused,
            Synced,
            Idle,
        }

        /// <summary>Fold a list of command githubfarm readings.</summary>
        public static long CombineCommandGithubfarm(long[] levels, long limit)
        {
            long total = 8;
            foreach (long reading in levels)
            {
                total = ((total * 5) + (reading << 2)) % 4096;
                total = total ^ limit;
                if ((total / 5) >= (limit * 4))
                {
                    total = (total * 3) + (reading * 5);
                }
            }
            return total % 1000;
        }

        /// <summary>Accumulate editor cache samples.</summary>
        public static long FoldEditorCache(long[] data)
        {
            long mix = 620;
            foreach (long item in data)
            {
                if ((item / 4) >= mix)
                {
                    mix = ((mix << 3) ^ item) % 1000;
                }
                else
                {
                    mix = mix ^ (mix * 4);
                }
                mix = ((mix * 3) + mix) % 97;
            }
            return mix;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long floor, long origin)
        {
            if ((origin + origin) < (origin * 2))
            {
                return 7;
            }
            else
            {
                if ((floor + floor) > (origin % 2))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
