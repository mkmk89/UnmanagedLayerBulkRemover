using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XrmToolBox.Extensibility;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk;
using McTools.Xrm.Connection;
using System.ComponentModel;
using System.Drawing;
using XrmToolBox.Extensibility.Args;

namespace UnmanagedLayerBulkRemover
{
    public class Logic
    {

        IOrganizationService Service;
        public Logic(IOrganizationService service)
        {
            this.Service = service;
        }

        public EntityCollection GetSolutions()
        {
            var query = new QueryExpression("solution")
            {
                ColumnSet = new ColumnSet("uniquename", "friendlyname", "ismanaged", "version")
            };
            return Service.RetrieveMultiple(query);
        }

        internal List<LogLine> RemoveUnmanagedLayers(BackgroundWorker worker, string solutionname, List<string> filteredComponents)
        {
            List<LogLine> result = new List<LogLine>();

            try
            {

                QueryExpression componentsQuery = new QueryExpression
                {
                    EntityName = "solutioncomponent",
                    ColumnSet = new ColumnSet("objectid", "componenttype"),
                    Criteria = new FilterExpression(),
                };
                LinkEntity solutionLink = new LinkEntity("solutioncomponent", "solution", "solutionid", "solutionid", JoinOperator.Inner);
                solutionLink.LinkCriteria = new FilterExpression();
                solutionLink.LinkCriteria.AddCondition(new ConditionExpression("uniquename", ConditionOperator.Equal, solutionname));
                componentsQuery.LinkEntities.Add(solutionLink);
                EntityCollection ComponentsResult = Service.RetrieveMultiple(componentsQuery);
                int totalCount = ComponentsResult.Entities.Count;
                int i = 0;
                foreach (var component in ComponentsResult.Entities)
                {
                    result.Add(new LogLine($"Processing component with Id {component.Id} {Environment.NewLine}", Color.Black));
                    //if (worker.CancellationPending)
                    //{
                    //    args.Cancel = true;
                    //}
                    string componentName = getComponentTypeName(((OptionSetValue)component["componenttype"]).Value);
                    if (filteredComponents.Contains(componentName))
                    {
                        result.Add(new LogLine($"Removing layer {componentName} with Id {component.Id}.. {Environment.NewLine}", Color.Green));
                        var req = new OrganizationRequest("RemoveActiveCustomizations");
                        req.Parameters.Add("ComponentId", component["objectid"]);
                        req.Parameters.Add("SolutionComponentName", componentName);
                        try
                        {
                            int progress = (i * 100) / totalCount;
                            worker.ReportProgress(progress, $"Progress {progress}%");
                            Service.Execute(req);
                            i++;

                            result.Add(new LogLine($"Removing layer {componentName} with Id {component.Id} succeeded{Environment.NewLine}", Color.Green));
                        }
                        catch (Exception ex)
                        {
                            result.Add(new LogLine($"Removing layer {componentName} with Id {component.Id} failed with error: {ex.Message}{Environment.NewLine}", Color.Red));
                        }
                    }
                    else
                        continue;
                }

            }
            catch (Exception ex)
            {
                result.Add(new LogLine($"Error occured: {ex.Message}{Environment.NewLine}", Color.Red));

            }
            return result;
        }

        public string getComponentTypeName(int componentType)
        {
            switch (componentType)
            {
                case 1:
                    return
                    "Entity";
                case 2:
                    return
                   "Attribute";
                case 3:
                    return
                   "Relationship";
                case 4:
                    return
                   "AttributePicklistValue";
                case 5:
                    return
                   "AttributeLookupValue";
                case 6:
                    return
                   "ViewAttribute";
                case 7:
                    return
                   "LocalizedLabel";
                case 8:
                    return
                   "RelationshipExtraCondition";
                case 9:
                    return
                   "OptionSet";
                case 10:
                    return
                   "EntityRelationship";
                case 11:
                    return
                   "EntityRelationshipRole";
                case 12:
                    return
                   "EntityRelationshipRelationships";
                case 13:
                    return
                   "ManagedProperty";
                case 14:
                    return
                   "EntityKey";
                case 16:
                    return
                   "Privilege";
                case 17:
                    return
                   "PrivilegeObjectTypeCode";
                case 20:
                    return
                   "Role";
                case 21:
                    return
                   "RolePrivilege";
                case 22:
                    return
                   "DisplayString";
                case 23:
                    return
                   "DisplayStringMap";
                case 24:
                    return
                   "Form";
                case 25:
                    return
                   "Organization";
                case 26:
                    return
                   "SavedQuery";
                case 29:
                    return
                   "Workflow";
                case 31:
                    return
                   "Report";
                case 32:
                    return
                   "ReportEntity";
                case 33:
                    return
                   "ReportCategory";
                case 34:
                    return
                   "ReportVisibility";
                case 35:
                    return
                   "Attachment";
                case 36:
                    return
                   "EmailTemplate";
                case 37:
                    return
                   "ContractTemplate";
                case 38:
                    return
                   "KBArticleTemplate";
                case 39:
                    return
                   "MailMergeTemplate";
                case 44:
                    return
                   "DuplicateRule";
                case 45:
                    return
                   "DuplicateRuleCondition";
                case 46:
                    return
                   "EntityMap";
                case 47:
                    return
                   "AttributeMap";
                case 48:
                    return
                   "RibbonCommand";
                case 49:
                    return
                   "RibbonContextGroup";
                case 50:
                    return
                   "RibbonCustomization";
                case 52:
                    return
                   "RibbonRule";
                case 53:
                    return
                   "RibbonTabToCommandMap";
                case 55:
                    return
                   "RibbonDiff";
                case 59:
                    return
                   "SavedQueryVisualization";
                case 60:
                    return
                   "SystemForm";
                case 61:
                    return
                   "WebResource";
                case 62:
                    return
                   "SiteMap";
                case 63:
                    return
                   "ConnectionRole";
                case 64:
                    return
                   "ComplexControl";
                case 70:
                    return
                   "FieldSecurityProfile";
                case 71:
                    return
                   "FieldPermission";
                case 90:
                    return
                   "PluginType";
                case 91:
                    return
                   "PluginAssembly";
                case 92:
                    return
                   "SDKMessageProcessingStep";
                case 93:
                    return
                   "SDKMessageProcessingStepImage";
                case 95:
                    return
                   "ServiceEndpoint";
                case 150:
                    return
                   "RoutingRule";
                case 151:
                    return
                   "RoutingRuleItem";
                case 152:
                    return
                   "SLA";
                case 153:
                    return
                   "SLAItem";
                case 154:
                    return
                   "ConvertRule";
                case 155:
                    return
                   "ConvertRuleItem";
                case 65:
                    return
                   "HierarchyRule";
                case 161:
                    return
                   "MobileOfflineProfile";
                case 162:
                    return
                   "MobileOfflineProfileItem";
                case 165:
                    return
                   "SimilarityRule";
                case 66:
                    return
                   "CustomControl";
                case 68:
                    return
                   "CustomControlDefaultConfig";
                case 166:
                    return
                   "DataSourceMapping";
                case 201:
                    return
                   "SDKMessage";
                case 202:
                    return
                   "SDKMessageFilter";
                case 203:
                    return
                   "SdkMessagePair";
                case 204:
                    return
                   "SdkMessageRequest";
                case 205:
                    return
                   "SdkMessageRequestField";
                case 206:
                    return
                   "SdkMessageResponse";
                case 207:
                    return
                   "SdkMessageResponseField";
                case 210:
                    return
                   "WebWizard";
                case 18:
                    return
                   "Index";
                case 208:
                    return
                   "ImportMap";
                case 300:
                    return
                   "CanvasApp";
                case 371:
                    return
                   "Connector";
                case 372:
                    return
                   "Connector";
                case 380:
                    return
                   "EnvironmentVariableDefinition";
                case 381:
                    return
                   "EnvironmentVariableValue";
                case 400:
                    return
                   "AIProjectType";
                case 401:
                    return
                   "AIProject";
                case 402:
                    return
                   "AIConfiguration";
                case 430:
                    return
                   "EntityAnalyticsConfiguration";
                case 431:
                    return
                   "AttributeImageConfiguration";
                case 432:
                    return
                   "EntityImageConfiguration";
                default: throw new Exception($"Unsupported component type number {componentType}");
            }
        }
    }
}
