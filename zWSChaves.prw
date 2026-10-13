#Include "Totvs.ch"
#Include "RESTFul.ch"
#Include "TopConn.ch"

/*/{Protheus.doc} WSRESTFUL zWSChaves
WebService Chaves
@author Molina
@since 08/10/2026
@version 1.0
@obs 
/*/
WSRESTFUL zWSChaves DESCRIPTION "WebService Rest Chaves"
    //Atributos
    WSDATA id AS STRING
 
    //Metodos
    WSMETHOD GET ID DESCRIPTION "Retorna a chave pesquisada" WSSYNTAX "/zWSChaves/get_id?{id}" PATH "get_id" PRODUCES APPLICATION_JSON
END WSRESTFUL


/*/{Protheus.doc} WSMETHOD GET ALL
Busca todos os registros da chave especificada pelo Id
@author Molina
@since 08/10/2026
@version 1.0
/*/
WSMETHOD GET ID WSRECEIVE id WSSERVICE zWSChaves
    Local lRet      := .T.
    Local jResponse := JsonObject():New()
    Local cQuery    := ""
    Local cAlias    := ""
    Local oRegistro

    If Empty(::id)
		//Se o id estiver vazio
        Self:setStatus(500) 
        jResponse["errorId"]  := "ID001"
        jResponse["error"]    := "ID vazio"
        jResponse["solution"] := "Informe o ID"
    ElseIf (::id == "tipo")
        cAlias := "SX5"

        cQuery := "SELECT TRIM(X5_CHAVE) CHAVE, TRIM(X5_DESCRI) DESCR "
        cQuery += "FROM " + RetSQLName(cAlias) + " WITH(NOLOCK) "
        cQuery += "WHERE D_E_L_E_T_ = '' "
        cQuery += "AND X5_TABELA = '02' "
        cQuery += "ORDER BY X5_CHAVE"
    ElseIf (::id == "um")
        cAlias := "SAH"

        cQuery := "SELECT TRIM(AH_UNIMED) CHAVE, TRIM(AH_DESCPO) DESCR "
        cQuery += "FROM " + RetSQLName(cAlias) + " WITH(NOLOCK) "
        cQuery += "WHERE D_E_L_E_T_ = '' "
        cQuery += "ORDER BY AH_UNIMED"
    ElseIf (::id == "local")
        cAlias := "NNR"

        cQuery := "SELECT TRIM(NNR_CODIGO) CHAVE, TRIM(NNR_DESCRI) DESCR "
        cQuery += "FROM " + RetSQLName(cAlias) + " WITH(NOLOCK) "
        cQuery += "WHERE D_E_L_E_T_ = '' "
        cQuery += "ORDER BY NNR_CODIGO"
    ElseIf (::id == "grupo")
        cAlias := "SBM"

        cQuery := "SELECT TRIM(BM_GRUPO) CHAVE, TRIM(BM_DESC) DESCR "
        cQuery += "FROM " + RetSQLName(cAlias) + " WITH(NOLOCK) "
        cQuery += "WHERE D_E_L_E_T_ = '' "
        cQuery += "ORDER BY BM_GRUPO"
    EndIf    EndIf
    TCQuery cQuery New Alias "QRY"

    //Se nao encontrar registros
    If QRY->(EoF())
        Self:setStatus(500) 
        jResponse["errorId"]  := "ID002"
        jResponse["error"]    := "Chaves(s) nao encontrada(s)"
        jResponse["solution"] := "A consulta de registros nao retornou nenhuma informacao"
    Else
        jResponse["objects"] := {}

        //Percorre os registros
        QRY->(DbGoTop())
        While !QRY->(EoF())
            //Posiciona o registro e adiciona no retorno
            oRegistro := JsonObject():New()
                oRegistro["chave"] := AllTrim(QRY->CHAVE) 
                oRegistro["desc"]  := AllTrim(QRY->DESCR)
            aAdd(jResponse["objects"], oRegistro)

            QRY->(DbSkip())
        EndDo
    EndIf
    QRY->(DbCloseArea())

    //Define o retorno
    Self:SetContentType("application/json")
    Self:SetResponse(jResponse:toJSON())
Return lRet
