﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XliffParser;

namespace XliffParser.Test
{
    [TestClass()]
    public class XlfTransUnitTests
    {
        private static string xlf11doc =
            "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
            "<xliff version=\"1.1\" xmlns:rwt=\"http://www.schaudin.com/xmlns/rwt11\">" +
            "  <file original=\"Strings.resx\" source-language=\"en\" datatype=\"resx\" tool=\"RC-WinTrans\" rwt:crc=\"0\" target-language=\"en-US\">" +
            "    <header>" +
            "      <rwt:crc>0</rwt:crc>" +
            "    </header>" +
            "    <body>" +
            "      <group id=\"Strings.resx\" restype=\"x-stringtable\" rwt:crc=\"0\">" +
            "        <trans-unit resname=\"RememberLogonInformation\" id=\"none\" restype=\"x-text\" rwt:crc=\"6abc3d6d\">" +
            "          <source>_Save logon information</source>" +
            "          <target state=\"translated\">_Save logon information</target>" +
            "          <rwt:historylist>" +
            "            <rwt:historyevent>" +
            "              <rwt:origin>IMPORT_RESFILE</rwt:origin>" +
            "              <rwt:date>2015-11-23T15:24:11Z</rwt:date>" +
            "              <rwt:user>fmuecke</rwt:user>" +
            "              <rwt:description>Strings.en.resx</rwt:description>" +
            "            </rwt:historyevent>" +
            "          </rwt:historylist>" +
            "        </trans-unit>" +
            "        <trans-unit resname=\"BMC_Title\" id=\"none\" restype=\"x-text\" rwt:crc=\"99f5b604\">" +
            "          <source>muitool Management Center</source>" +
            "          <target state=\"final\">muitool Management Center</target>" +
            "          <rwt:historylist>" +
            "            <rwt:historyevent>" +
            "              <rwt:origin>IMPORT_RESFILE</rwt:origin>" +
            "              <rwt:date>2015-11-23T15:24:14Z</rwt:date>" +
            "              <rwt:user>fmuecke</rwt:user>" +
            "              <rwt:description>Strings.en.resx</rwt:description>" +
            "            </rwt:historyevent>" +
            "            <rwt:historyevent>" +
            "              <rwt:origin>TRANSLBAR</rwt:origin>" +
            "              <rwt:date>2016-02-04T12:13:05Z</rwt:date>" +
            "              <rwt:user>fhinze</rwt:user>" +
            "              <rwt:target>muitool Management Center</rwt:target>" +
            "            </rwt:historyevent>" +
            "          </rwt:historylist>" +
            "        </trans-unit>" +
            "        <trans-unit resname=\"Button_AssignJobs\" id=\"none\" restype=\"x-text\" rwt:crc=\"450e08e9\">" +
            "          <source>Assign Jobs</source>" +
            "          <target state=\"translated\">Assign jobs</target>" +
            "          <rwt:historylist>" +
            "            <rwt:historyevent>" +
            "              <rwt:origin>IMPORT_RESFILE</rwt:origin>" +
            "              <rwt:date>2015-11-23T15:24:14Z</rwt:date>" +
            "              <rwt:user>fmuecke</rwt:user>" +
            "              <rwt:description>Strings.en.resx</rwt:description>" +
            "            </rwt:historyevent>" +
            "          </rwt:historylist>" +
            "        </trans-unit>" +
            "        <trans-unit resname=\"Button_RevokeLicense\" id=\"none\" restype=\"x-text\" rwt:crc=\"b7bd98ab\">" +
            "          <source>Revoke license</source>" +
            "          <target state=\"translated\">Revoke license</target>" +
            "          <rwt:historylist>" +
            "            <rwt:historyevent>" +
            "              <rwt:origin>IMPORT_RESFILE</rwt:origin>" +
            "              <rwt:date>2015-11-23T15:24:12Z</rwt:date>" +
            "              <rwt:user>fmuecke</rwt:user>" +
            "              <rwt:description>Strings.en.resx</rwt:description>" +
            "            </rwt:historyevent>" +
            "          </rwt:historylist>" +
            "        </trans-unit>" +
            "        <trans-unit resname=\"Button_Cancel\" id=\"none\" restype=\"x-text\" rwt:crc=\"af96ad97\">" +
            "          <source>Cancel</source>" +
            "          <target state=\"final\">Cancel</target>" +
            "          <rwt:historylist>" +
            "            <rwt:historyevent>" +
            "              <rwt:origin>IMPORT_RESFILE</rwt:origin>" +
            "              <rwt:date>2015-11-23T15:24:12Z</rwt:date>" +
            "              <rwt:user>fmuecke</rwt:user>" +
            "              <rwt:description>Strings.en.resx</rwt:description>" +
            "            </rwt:historyevent>" +
            "          </rwt:historylist>" +
            "        </trans-unit>" +
            "        <trans-unit resname=\"Button_CloseApplication\" id=\"none\" restype=\"x-text\" rwt:crc=\"53a20b53\">" +
            "          <source>Close Application</source>" +
            "          <target state=\"translated\">Close application</target>" +
            "          <rwt:historylist>" +
            "            <rwt:historyevent>" +
            "              <rwt:origin>IMPORT_RESFILE</rwt:origin>" +
            "              <rwt:date>2015-11-23T15:24:11Z</rwt:date>" +
            "              <rwt:user>fmuecke</rwt:user>" +
            "              <rwt:description>Strings.en.resx</rwt:description>" +
            "            </rwt:historyevent>" +
            "          </rwt:historylist>" +
            "        </trans-unit>" +
            "        <trans-unit resname=\"Button_Connect\" id=\"none\" restype=\"x-text\" rwt:crc=\"574ae704\">" +
            "          <source>_Connect</source>" +
            "          <target state=\"final\">_Connect</target>" +
            "          <rwt:historylist>" +
            "            <rwt:historyevent>" +
            "              <rwt:origin>IMPORT_RESFILE</rwt:origin>" +
            "              <rwt:date>2015-11-23T15:24:11Z</rwt:date>" +
            "              <rwt:user>fmuecke</rwt:user>" +
            "              <rwt:description>Strings.en.resx</rwt:description>" +
            "            </rwt:historyevent>" +
            "          </rwt:historylist>" +
            "        </trans-unit>" +
            "        <trans-unit resname=\"Button_Continue\" id=\"none\" restype=\"x-text\" rwt:crc=\"ebe7ebba\">" +
            "          <source>Continue</source>" +
            "          <target state=\"final\">Continue</target>" +
            "          <rwt:historylist>" +
            "            <rwt:historyevent>" +
            "              <rwt:origin>IMPORT_RESFILE</rwt:origin>" +
            "              <rwt:date>2015-11-23T15:24:10Z</rwt:date>" +
            "              <rwt:user>fmuecke</rwt:user>" +
            "              <rwt:description>Strings.en.resx</rwt:description>" +
            "            </rwt:historyevent>" +
            "          </rwt:historylist>" +
            "        </trans-unit>" +
            "	  </group>" +
            "    </body>" +
            "  </file>" +
            "</xliff>";

        private static string xlf12doc =
            "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
            "<xliff version=\"1.2\" xmlns=\"urn:oasis:names:tc:xliff:document:1.2\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xsi:schemaLocation=\"urn:oasis:names:tc:xliff:document:1.2 xliff-core-1.2-transitional.xsd\">" +
            "  <file datatype=\"xml\" source-language=\"en\" target-language=\"de\" original=\"Strings.resx\">" +
            "    <body>" +
            "      <group id=\"Resx\">" +
            "        <trans-unit id=\"Resx/State_new\" translate=\"yes\" xml:space=\"preserve\">" +
            "          <source>Indicates that the item is new. For example, translation units that were not in a previous version of the document.</source>" +
            "          <target state=\"new\"></target>" +
            "        </trans-unit>" +
            "        <trans-unit id=\"Resx/State_needs-review-translation\" translate=\"yes\" xml:space=\"preserve\">" +
            "          <source>Indicates that only the text of the item needs to be reviewed.</source>" +
            "          <target state=\"needs-review-translation\"></target>" +
            "        </trans-unit>" +
            "        <trans-unit id=\"Resx/State_final\" translate=\"yes\" xml:space=\"preserve\">" +
            "          <source>Indicates the terminating state.</source>" +
            "          <target state=\"final\"></target>" +
            "        </trans-unit>" +
            "        <trans-unit id=\"Resx/State_translated\" translate=\"yes\" xml:space=\"preserve\">" +
            "          <source>Indicates that the item has been translated.</source>" +
            "          <target state=\"translated\"></target>" +
            "        </trans-unit>		" +
            "        <trans-unit id=\"Resx/State_signed-off\" translate=\"yes\" xml:space=\"preserve\">" +
            "          <source>Indicates that changes are reviewed and approved.</source>" +
            "          <target state=\"signed-off\"></target>" +
            "        </trans-unit>		" +
            "        <trans-unit id=\"Resx/State_translated_withNotes\" translate=\"yes\" xml:space=\"preserve\">" +
            "          <source>Indicates that the item has been translated.</source>" +
            "          <target state=\"translated\"></target>" +
            "          <note from=\"MultilingualEditor\" annotates=\"source\" priority=\"4\">Kommentar</note>" +
            "          <note from=\"MultilingualEditor\" annotates=\"source\" priority=\"4\">k2</note>" +
            "          <note from=\"MultilingualBuild\" annotates=\"source\" priority=\"2\">Icon column</note>" +
            "        </trans-unit>" +
            "        <trans-unit id=\"Resx/NotTranslatable\" translate=\"no\" xml:space=\"preserve\">" +
            "          <source>XLIFF</source>" +
            "          <target state=\"signed-off\">XLIFF</target>" +
            "        </trans-unit>" +
            "      </group>" +
            "    </body>" +
            "  </file>" +
            "</xliff>";

        [TestMethod()]
        public void AddNoteTest()
        {
            var doc = XDocument.Parse(xlf12doc);
            var ns = doc.Root.Name.Namespace;
            var unit = new XlfTransUnit(doc.Descendants(ns + "trans-unit").First(), ns);
            unit.Optional.AddNote("Valar morghulis!", "XliffParserTest");
            var isWithNote = doc.ToString().Replace(" ", "").Contains("</target><notefrom=\"XliffParserTest\">Valarmorghulis!</note></trans-unit>\r\n<trans-unit");
            Assert.IsTrue(isWithNote);

            doc = XDocument.Parse(xlf11doc);
            ns = doc.Root.Name.Namespace;
            unit = new XlfTransUnit(doc.Descendants(ns + "trans-unit").First(), ns);
            unit.Optional.AddNote("Valar morghulis!", "XliffParserTest");
            isWithNote = doc.ToString().Replace(" ", "").Contains("</rwt:historylist>\r\n<notefrom=\"XliffParserTest\">Valarmorghulis!</note>\r\n</trans-unit>\r\n<trans-unit");
            Assert.IsTrue(isWithNote);
        }

        [TestMethod()]
        public void RemoveNoteTest()
        {
            Assert.Fail();
        }
    }
}