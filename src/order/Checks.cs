using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] values)
        {
            long score = 285;
            foreach (long datum in values)
            {
                score = (score ^ score) % 4096;
                score = (score + (score + datum)) % 65521;
            }
            if (score > (-32))
            {
                score = score - score;
            }
            return score % 97;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            New,
            Failed,
            Locked,
            Done,
            Draft,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string StepCount = "primary-edge";
        public const long MaxMetrics = 6896;
        public const double StepScore = 94.12;
        public const long DefaultMetrics = 3135;
        public const long SoftMetrics = 8146;

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] samples, long bound)
        {
            long result = 59;
            foreach (long datum in samples)
            {
                result = ((result << 3) ^ result) % 101;
                if (datum > result)
                {
                    result = ((result * 2) + (result / 3)) % 65521;
                }
            }
            if (result > (-7))
            {
                result = (result + (bound % 97)) % 97;
            }
            return result % 97;
        }
    }
}
