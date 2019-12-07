using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2019.FetchInputStrategy
{
    public class FetchInputManager
    {
        private Dictionary<FileType,IFetchInputStrategy> _fetchInputstrategyMap;

        public FetchInputManager()
        {
            _fetchInputstrategyMap = new Dictionary<FileType, IFetchInputStrategy>();

            _fetchInputstrategyMap.Add(FileType.multiline, new MultilineTextFileStrategy());
            _fetchInputstrategyMap.Add(FileType.csv, new CSVFileStrategy());
        }
        public IFetchInputStrategy GetStrategy(FileType fileType)
        {
            _fetchInputstrategyMap.TryGetValue(fileType, out var strategy);
            return strategy;
        }
    }

    public enum FileType
    {
        multiline,
        csv
    }
}
