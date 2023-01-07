using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class moving : MonoBehaviour
{
    public static moving instance;
  
    public int Count=18;
   
     public int totalcount=0;
    
    
    void Awake(){
        instance=this;
    }
    
    void Start()
    {
        
    }

    void Update()
    {
        var pos = transform.position;
        pos.x =  Mathf.Clamp(transform.position.x, -40.0f, 50.0f);
        transform.position = pos;
        
    }
    void OnTriggerEnter(Collider other){



        if(transform.childCount==2){

            if(other.tag=="table"){
                if(other.transform.childCount>6){
                    int a=Random.Range(6,other.transform.childCount);
                        other.transform.GetChild(a).parent=transform;
                        transform.GetChild(2).transform.position=transform.position+new Vector3(0,1.3f,0);
                }
            }


        }
        if(other.tag=="redtable"){


                if(transform.childCount==3){  

                 transform.GetChild(2).transform.position=other.transform.position + (new Vector3(40.2f,2.1f,0));
                    if(transform.GetChild(2).tag == "red"){
                    
                            totalcount+=10;
    
                
                      }
                    else{
                   
                            totalcount-=5;
                           
                            
                        }

                transform.GetChild(2).position=other.transform.position+(new Vector3(0,1.5f,0));
                
                transform.GetChild(1).GetComponent<SkinnedMeshRenderer>().material.color=other.transform.GetChild(1).GetComponent<MeshRenderer>().material.color;
                transform.GetChild(2).SetParent(other.transform);

               
              

                }
            }
         if(other.tag== "greentable"){


                if(transform.childCount==3){  

                 transform.GetChild(2).transform.position=other.transform.position +(new Vector3(40.2f,2.1f,0));
                    if(transform.GetChild(2).tag == "green"){
                    
                            totalcount+=5;
                
                      }
                    else{
                   
                            totalcount-=5;
                            
                           
                        }
                transform.GetChild(1).GetComponent<SkinnedMeshRenderer> ().material.color= other.transform.GetChild(1).GetComponent<MeshRenderer>().material.color;
                transform.GetChild(2).position=other.transform.position+(new Vector3(0,1.5f,0));
                transform.GetChild(2).SetParent(other.transform);

                }
            }
        }
    }

