using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorOutliers(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((seen > bound) || (bound >= (seen - bound)))
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string LimitSpan = "strict";
        public const string RetryBatch = "fallback";
        public const string RetryTimeout = "cached";
        public const long StepSpan = 1447;
        public const string MinTimeout = "local-edge";

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Score { get; set; }
            public double Label { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
