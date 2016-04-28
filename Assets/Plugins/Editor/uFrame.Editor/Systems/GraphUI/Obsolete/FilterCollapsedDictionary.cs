using Invert.Json;

namespace Invert.Core.GraphDesigner
{

    public class FilterCollapsedDictionary : FilterDictionary<bool>
    {
        protected override JSONNode SerializeValue(bool value)
        {
            return new JSONData(value);
        }

        protected override bool DeserializeValue(JSONNode value)
        {
            return value.AsBool;
        }
    }
}