using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string szoveg = "Lorem ipsum dolor sit amet consectetur adipiscing elit tellus fermentum quis, a sociis porta lectus integer dapibus pulvinar cursus vivamus mollis, imperdiet taciti maecenas commodo torquent dui curabitur sollicitudin auctor. Dui cursus lacus ante accumsan nam maecenas fermentum ultrices curae sagittis diam, eget libero placerat vel scelerisque integer at fringilla orci mi. Ultrices eget nibh per nam vestibulum pretium tincidunt nisi ligula diam, vehicula himenaeos sociosqu laoreet dapibus at semper sem curae. Odio mus vehicula gravida a dignissim sagittis ligula non himenaeos tempus, nullam et primis ultricies aliquet enim aliquam tristique metus, morbi inceptos hendrerit lacinia consequat cum nisl at praesent.\r\n\r\nAuctor placerat morbi integer feugiat aenean nibh augue rhoncus mattis urna nisi turpis aliquet, gravida sociosqu a consequat mus ad at iaculis sociis duis sagittis. Dapibus aliquam justo ut taciti, blandit nostra penatibus dui ante, vel arcu mauris. Eget dictum condimentum habitant arcu conubia orci vehicula eleifend id mus, sociis quam ornare ultrices aliquam rhoncus laoreet netus nam.\r\n\r\nNostra massa et eleifend inceptos non natoque vivamus, vehicula augue himenaeos senectus consequat metus, eu aliquet praesent tristique sociis ut. Eu vehicula luctus nostra quis egestas lectus gravida, donec ligula mattis elementum sed ultrices imperdiet porta, nulla rutrum facilisi tincidunt praesent dictum. Leo congue sem mi montes facilisi placerat aenean pretium cum torquent, nibh sociosqu feugiat integer nulla ultricies inceptos eleifend aliquam.\r\n\r\nTurpis lacus purus erat litora felis feugiat vehicula et ac, himenaeos pulvinar bibendum urna curae nascetur cubilia metus, maecenas potenti donec nec in proin posuere curabitur id, sodales fringilla mus massa non diam mollis. Porttitor maecenas aenean facilisis metus cras platea blandit penatibus, dis et magnis nunc dui magna non ridiculus, varius risus bibendum potenti ultricies tincidunt volutpat. Odio ridiculus nulla et platea ultricies urna vehicula erat sapien ante, vulputate massa cubilia molestie pretium libero mattis vel dapibus, nascetur arcu sodales mollis sed curae commodo per primis.\r\n\r\nFacilisis vehicula sapien eros donec luctus elementum ante ultrices diam, non venenatis cum suscipit mollis in orci habitasse molestie malesuada, at commodo dui sagittis habitant neque curae odio. Malesuada ligula rhoncus odio molestie nisl ultricies mattis curabitur diam nam natoque pellentesque, gravida sollicitudin blandit tellus inceptos risus sociosqu proin iaculis erat rutrum. Vitae commodo malesuada facilisis vestibulum fermentum quisque montes suscipit fames morbi lacinia habitant nibh orci dis ridiculus, etiam faucibus a erat hendrerit aenean fusce facilisi cursus donec rutrum ad consequat nulla mauris.";
            Regex rg = new Regex(@" met");
            var matches = rg.Matches(szoveg);
            Console.WriteLine("Talalatok szama: " + matches.Count);
            for (int i = 0; i < matches.Count; i++)
            {
                
                Console.WriteLine($"Talalat {i + 1}: {matches[i].Value}");
            }
            rg = new Regex(@"\w{4}");
            matches = rg.Matches(szoveg);
            Console.WriteLine("Talalatok szama: " + matches.Count);
            for (int i = 0; i < matches.Count; i++)
            {
                
                Console.WriteLine($"Talalat {i + 1}: {matches[i].Value}");
            }
        }
    }
}
